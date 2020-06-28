using System;
using System.ComponentModel;
using System.Linq;
using GF.Api;
using GF.Api.Balances;
using GF.Api.Connection;
using GF.Api.Orders;
using GF.Api.Positions;
using GF.Api.Values.Orders;
using GF.BasicExample.Converters;
using GF.BasicExample.Managers;
using GF.Api.Values.Orders;
using GF.Api.Orders.Drafts;
using System.Diagnostics;

namespace GF.BasicExample.Processors
{
    public sealed class PositionsProcessor : DataProcessorBase<object>, IDescriptionProvider
    {

        double trail_tgt { get; set; }
        double trail_dec { get; set; }
        double fixed_stop { get; set; }
        Dictionary<string, bool> trail_on { get; set; }
        Dictionary<string, double> hi_pnl { get; set; }
        Dictionary<string, double> trigger_pnl { get; set; }


        static PositionsProcessor()
        {
            TypeDescriptor.AddAttributes(typeof(IBalance), new TypeConverterAttribute(typeof(Balance)));
            TypeDescriptor.AddAttributes(typeof(IPosition), new TypeConverterAttribute(typeof(Position)));
        }

        public PositionsProcessor(IGFClient client)
            : base(client)
        {
        }

        public string GetItemDescription(object item)
        {
            return DescriptionManager.ToDescription<IPosition>(item, (position, sb) =>
            {
                if (CanExitPosition(position))
                {
                    sb.AppendLine();
                    sb.AppendLine(" * Double click to exit position");
                }
            });
        }

        public bool CanExitPosition(IPosition position)
        {
            return position != null && GetPositionVolume(position) != 0;
        }

        public IOrder ExitPosition(IPosition position, OrdersProcessor orderProcessor)
        {
            var volume = GetPositionVolume(position);

            return orderProcessor.SendOrder(
                volume > 0 ? OrderSide.Buy : OrderSide.Sell,
                Math.Abs(volume),
                position.Contract,
                OrderType.Market);
        }

        //ExitPosition with no Position required... Does require contract and EventArgs...
        public IOrder ExitPosition_Alt(GF.Api.Contracts.IContract contract, OrdersProcessor orderProcessor, EventArgs e)
        {
            //var vol = GetPositionVolume(position) //Requires position here too!
            var qty = Math.Abs(e.ContractPosition.Net.Volume);
            return orderProcessor.SendOrder(
                vol < 0 ? OrderSide.BuyToCover : OrderSide.Sell,
                Math.Abs(vol),
                contract,
                OrderType.Market);
                
        }

        protected override void OnLoginComplete(IGFClient client, LoginCompleteEventArgs e)
        {
            base.OnLoginComplete(client, e);

            RefreshPositions();
            client.Accounts.BalanceChanged += RefreshPositions;
            client.Accounts.AvgPositionChanged += RefreshPositions;
            client.Accounts.AccountSummaryChanged += RefreshPositions;
        }

        private void RefreshPositions(IGFClient client, EventArgs e)
        {
            RefreshPositions();
            RunCatTrail(e);                 //Hoping this is the thing called ^^ via += ?  It MUST be bc this CALLS other, so this is called first.
            Debug.WriteLine("Called RunCatTrail() via RefreshPositions");


            //IF run only ONCE ...
            //Run(e);
            //Debug.WriteLine("Called Run() via RefreshPositions");

        }

        private void RefreshPositions()
        {
            // Most traders have only one account
            var account = Client.Accounts.Get().FirstOrDefault();

            // Position OTE property contains theoretical profit/loss value in USD.
            // TotalBalance property is a sum of all balances for each currency converted to USD.
            LoadItems(Enumerable.Concat(account?.AvgPositions.Values.Cast<object>(), new[] { account.TotalBalance })
                     ?? new[] { "No accounts found" });
        }

        private int GetPositionVolume(IPosition position)
        {
//            return position.Net.Volume;
            return position.Short.Volume - position.Long.Volume;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                Client.Accounts.BalanceChanged -= RefreshPositions;
                Client.Accounts.AvgPositionChanged -= RefreshPositions;
                Client.Accounts.AccountSummaryChanged -= RefreshPositions;
            }
        }

        //Addits -- -------------------------------------------------------------------------------------------------------------
        
        public int RunCatTrail(GF.Api.Positions.PositionChangedEventArgs e)
        {

            //var account = gfClient.Accounts.Get().FirstOrDefault();
            //Should be inside loop ? Called inside loop?
            //var positions = GetOpenPositions(account, e);                     //Just in case we need more detail / Safety...

            int ret = 0;
            foreach (var pos in e.AsArray())
            {
                ret = check_ts_cs(pos);
                switch (ret)
                {
                    case 0:
                        break;

                    case -1:
                        Console.WriteLine($"CatStop Triggered -- Exiting position in {e.ContractPosition.Contract.Symbol}");
                        break;

                    case 1:
                        Console.WriteLine($"TrailStop Triggered -- Exiting position in {e.ContractPosition.Contract.Symbol}");
                        break;

                    default:
                        Console.WriteLine($"Error -- Please check position in {e.ContractPosition.Contract.Symbol}");
                        break;
                }

                if (ret != 0)
                {
                    var qty = Math.Abs(e.ContractPosition.Net.Volume);
                    if (e.ContractPosition.Net.Volume < 0)
                    {
                        PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.BuyToCover, qty);
                        //ExitPosition(e.ContractPosition.position, ) 
                        // ^^  Requires IPosition position argument.. not present here!  Doesnt make sense HOW called in MainForm.cs? WHERE is lbPositoin / IPosition passed?
                        Console.WriteLine("SX order sent.");
                    }
                    if (e.ContractPosition.Net.Volume > 0)
                    {
                        PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.Sell, qty);
                        Console.WriteLine("LX order sent.");
                    }

                }
            }
            return ret;
        }

        //Initial Version...
        public int run_cat_trail(GF.Api.Positions.PositionChangedEventArgs e)
        {

            //var account = gfClient.Accounts.Get().FirstOrDefault();
            //Should be inside loop ? Called inside loop?
            //var positions = GetOpenPositions(account, e);                     //Just in case we need more detail / Safety...

            int ret = 0;
            foreach (var pos in e.AsArray())
            {
                ret = check_ts_cs(pos);
                switch (ret)
                {
                    case 0:
                        break;

                    case -1:
                        Console.WriteLine($"CatStop Triggered -- Exiting position in {e.ContractPosition.Contract.Symbol}");
                        break;

                    case 1:
                        Console.WriteLine($"TrailStop Triggered -- Exiting position in {e.ContractPosition.Contract.Symbol}");
                        break;

                    default:
                        Console.WriteLine($"Error -- Please check position in {e.ContractPosition.Contract.Symbol}");
                        break;
                }

                if (ret != 0)
                {
                    var qty = Math.Abs(e.ContractPosition.Net.Volume);
                    if (e.ContractPosition.Net.Volume < 0)
                    {
                        PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.BuyToCover, qty);
                        Console.WriteLine("SX order sent.");
                    }
                    if (e.ContractPosition.Net.Volume > 0)
                    {
                        PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.Sell, qty);
                        Console.WriteLine("LX order sent.");
                    }

                }
            }
            return ret;
        }

        public int check_ts_cs(GF.Api.Positions.PositionChangedEventArgs e)
        {
            //Called inside of loop of positions in Array  : )
            var opl = get_position_pnl(gfClient, e);
            var sym = e.ContractPosition.Contract.Symbol;

            var def = false;
            var idef = 0.0;

            //If no value in dict, save them in -- (Avoid errors)
            if (hi_pnl.TryGetValue(sym, out idef))                              //Make sure this doesnt write over any current value?
            {
                hi_pnl[sym] = 0;
                trigger_pnl[sym] = 0;
            }


            //If new high, write over past hi_pnl
            if (opl > hi_pnl[sym])                                          //MIGHT need to init this dictionary when position opens?
            {
                hi_pnl[sym] = opl;

            }

            //Update Trigger price...
            trigger_pnl[sym] = hi_pnl[sym] * (1 - trail_dec);

            //Begin Trailing with Trigger...
            if (opl >= trail_tgt)
            {

                if (!trail_on.TryGetValue(sym, out def))
                    trail_on[sym] = true;

            }

            if (trail_on[sym])
            {
                if (opl <= trigger_pnl[sym])
                {
                    Console.WriteLine($"Exitting {sym} at {opl}");
                    //PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.BuyToCover);  -- Replace w MKT order (or STOP ordeR?)
                    return 1;                                                   //signals time to exit... and logs -- Cleaner.
                }

            }

            if (opl <= fixed_stop)
            {
                return -1;
            }

           return 0;
        }




        //Helper function to simplify run_cat_trail function... -- BETTER version in closeposition logic...
        //GF.Api.Positions.PositionChangedEventArgs (Old Type Argument)
        public int Go_Flat(EventArgs e)
        {

            var symbol = e.ContractPosition.Contract.Symbol;
            var net_basis = e.ContractPosition.Net.Volume;
            int _basis = net_basis > 0 ? 1 : -1;

            var close_qty = Math.Abs(net_basis);
            Console.WriteLine($"Exitting Position in -- {symbol}");
            switch (_basis)
            {
                case -1:
                    PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.BuyToCover, close_qty);
                    return 0;

                case 1:
                    PlaceOrder(gfClient, e.ContractPosition.Contract.ElectronicContract, OrderSide.Sell, close_qty);
                    return 0;

                default:
                    return -1;
            }
        }

        private static void PlaceOrder(GF.Api.IGFClient client, GF.Api.Contracts.IContract contract, GF.Api.Values.Orders.OrderSide orderSide, int qty, double limitPrice = 0.0, string comments = "")
        {

            //var qty = position.Net.Volume;
            //TWEAK THIS SO THAT IF LIMITPRICE = 0.0, MARKET ORDER!!!!
            if (client.Orders.Get().Count == 0 || client.Orders.Get().Last().IsFinalState)
            {
                OrderDraft orderDraft = new OrderDraftBuilder()
                    .WithAccountID(client.Accounts.Get().First().ID)
                    .WithContractID(contract.ID)
                    .WithSide(orderSide)
                    .WithOrderType(GF.Api.Values.Orders.OrderType.Market)
                    //.WithPrice(limitPrice)
                    .WithQuantity(qty)
                    .WithEnd(DateTime.UtcNow.AddMinutes(1))
                    .WithComments(comments)
                    .Build();
                IReadOnlyList<OrderDraftValidationError> validationErrors = client.Orders.Drafts.Validate(orderDraft);
                if (validationErrors.Any())
                {
                    Console.WriteLine($"ERROR. Order {orderSide} {orderDraft.Quantity} {contract.Symbol} @ {contract.PriceToString(limitPrice)} Limit is invalid:");
                    foreach (var error in validationErrors)
                        Console.WriteLine($"\t{error.Message}");
                }
                else
                {
                    GF.Api.Orders.IOrder order = client.Orders.SendOrder(orderDraft);
                    Console.WriteLine($"Order {order} was sent");
                }
            }
        }


        //Original Arg Type GF.Api.Positions.PositionChangedEventArgs
        public void Run(EventArgs e, int EOD = 1600)
        {
            //Gets Datetime and uses inf loop to check for new positions, and manage the trailstop -- Eventually could also use OnBar for entries.
            //Maybe should be using onBar bc new position only on bars...
            DateTime now = DateTime.Now;
            DateTime saveUtcNow = DateTime.UtcNow; //If needed later...
            TimeSpan FUT_gap = new TimeSpan(0, 2, 0, 0); //0 days, 10 hours, 5 minutes and 1 second
            //tempDate.ToString("MMMM dd, yyyy")
            var ns = now.ToString("HH:mm:ss");

            Console.WriteLine("Checking for Market Open...");
            if (now.Hour == EOD) { Console.WriteLine("Waiting for Market Reopen."); }
            while (now.Hour == EOD)
            {
                now = DateTime.Now;
                Thread.Sleep(1000 * 60 * 5);                                    //5min Sleep -- waiting for re-open

            }
            Console.WriteLine("Market now Open.");

            RegisterOnAvgPositionChanged(gfClient);                             //Hopefully starts the event loop?
            while (true)
            {

                now = DateTime.Now;
                //need to call heartbeat? (runner?)

                //Check if Closed FIRST -- so don't accidentally exit in non-hours
                if (now.Hour == EOD)
                {
                    now = DateTime.Now;
                    Thread.Sleep(1000 * 60 * 60);
                }

                //Entry Stuff / OnBar could also be called right here...  might want to check that flat tho (return from onBar?)

                ns = now.ToString("HH:mm:ss");
                Debug.WriteLine($"Running check_ts_cs -- {ns}");
                run_cat_trail(e);



                Debug.WriteLine("Iteration Done ...");

            }
        }


    }
    }

﻿using CryptoExchange.Net.Converters;
using Okex.Net.Enums;
using System.Collections.Generic;

namespace Okex.Net.Converters
{
    internal class FundingBillTypeConverter : BaseConverter<OkexFundingBillType>
    {
        public FundingBillTypeConverter() : this(true) { }
        public FundingBillTypeConverter(bool quotes) : base(quotes) { }

        protected override List<KeyValuePair<OkexFundingBillType, string>> Mapping => new List<KeyValuePair<OkexFundingBillType, string>>
        {
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Deposit, "1"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Withdrawal, "2"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CanceledWithdrawal, "13"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToFutures, "18"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromFutures, "19"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToSubAccount, "20"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromSubAccount, "21"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Claim, "28"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToMargin, "33"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromMargin, "34"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToSpot, "37"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromSpot, "38"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TradingFeesSettledByLoyaltyPoints, "41"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.LoyaltyPointsPurchase, "42"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.SystemReversal, "47"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.ReceivedFromActivities, "48"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.GivenAwayToActivities, "49"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.ReceivedFromAppointments, "50"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.DeductedFromAppointments, "51"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RedPacketSent, "52"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RedPacketSnatched, "53"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RedPacketRefunded, "54"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToPerpetual, "55"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromPerpetual, "56"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromHedgingAccount, "59"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToHedgingAccount, "60"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Conversion, "61"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferToOptions, "63"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferFromOptions, "62"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.ClaimRebateCard, "68"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.DistributeRebateCard, "69"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TokenReceived, "72"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TokenGivenAway, "73"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TokenRefunded, "74"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.SubscriptionToSavings, "75"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RedemptionToSavings, "76"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Distribute, "77"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.LockUp, "78"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.NodeVoting, "79"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Staking80, "80"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.VoteRedemption, "81"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.StakingRedemption82, "82"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.StakingYield, "83"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.ViolationFee, "84"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.PowMiningYield, "85"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CloudMiningPay, "86"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CloudMiningYield, "87"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Subsidy, "88"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Staking89, "89"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.StakingSubscription, "90"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.StakingRedemption91, "91"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.AddCollateral, "92"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RedeemCollateral, "93"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.Investment, "94"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.BorrowerBorrows, "95"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.PrincipalTransferredIn, "96"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.BorrowerTransferredLoanOut, "97"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.BorrowerTransferredInterestOut, "98"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InvestorTransferredInterestIn, "99"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.PrepaymentPenaltyTransferredIn, "102"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.PrepaymentPenaltyTransferredOut, "103"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FeeTransferredIn, "104"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FeeTransferredOut, "105"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.OverdueFeeTransferredIn, "106"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.OverdueFeeTransferredOut, "107"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.OverdueInterestTransferredOut, "108"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.OverdueInterestTransferredIn, "109"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CollateralForClosedPositionTransferredIn, "110"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CollateralForClosedPositionTransferredOut, "111"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CollateralForLiquidationTransferredIn, "112"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CollateralForLiquidationTransferredOut, "113"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InsuranceFundTransferredIn, "114"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InsuranceFundTransferredOut, "115"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.PlaceAnOrder, "116"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FulfillAnOrder, "117"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.CancelAnOrder, "118"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.MerchantsUnlockDeposit, "119"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.MerchantsAddDeposit, "120"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FiatgatewayPlaceAnOrder, "121"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FiatgatewayCancelAnOrder, "122"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.FiatgatewayFulfillAnOrder, "123"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.JumpstartUnlocking, "124"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.ManualDeposit, "125"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InterestDeposit, "126"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InvestmentFeeTransferredIn, "127"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.InvestmentFeeTransferredOut, "128"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.RewardsTransferredIn, "129"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferredFromUnifiedAccount, "130"),
             new KeyValuePair<OkexFundingBillType, string>(OkexFundingBillType.TransferredToUnifiedAccount, "131"),
        };
    }
}
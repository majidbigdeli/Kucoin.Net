﻿namespace Kucoin.Net.Enums
{
    /// <summary>
    /// Status of a Borrow Order
    /// </summary>
    public enum BorrowStatus
    {
        /// <summary>
        /// In progress
        /// </summary>
        Processing,
        /// <summary>
        /// Done 
        /// </summary>
        Done
    }

    public enum RepayStatus
    {

        Repaying,

        Completed,

        Failed

    }
}

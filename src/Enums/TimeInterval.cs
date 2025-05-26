namespace OoplesFinance.YahooFinanceAPI.Enums;

public enum TimeInterval
{
    /// <summary>
    /// Up to 5 days of intraday data available
    /// </summary>
    _1Minute,

    /// <summary>
    /// Up to 60 days of intraday data available; limited symbol support
    /// </summary>
    _2Minutes,

    /// <summary>
    /// Up to 60 days of intraday data available
    /// </summary>
    _5Minutes,

    /// <summary>
    /// Up to 60 days of intraday data available
    /// </summary>
    _15Minutes,

    /// <summary>
    /// Up to 60 days of intraday data available
    /// </summary>
    _30Minutes,

    /// <summary>
    /// Up to 730 days of intraday data available
    /// </summary>
    _60Minutes,

    /// <summary>
    /// Limited support; not reliably available across all symbols
    /// </summary>
    _90Minutes,

    /// <summary>
    /// Same as _60Minutes; up to 730 days of data available
    /// </summary>
    _1Hour,

    /// <summary>
    /// Full historical daily data available
    /// </summary>
    _1Day,

    // Used as a predefined range, not a true interval
    _5Days,

    // Full historical weekly data available
    _1Week,

    // Full historical monthly data available
    _1Month,

    // Used as a predefined range; not a supported interval value
    _3Months
}

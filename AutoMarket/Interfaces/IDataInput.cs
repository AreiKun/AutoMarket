using System;

namespace AutoMarket
{
    interface IDataInput
    {
        string EnteringModelValue();
        string EnteringNumberValue();
        public int EnteringMileageValue();
        public int EnteringPriceValue();
        DateTime DateEntry();
    }
}

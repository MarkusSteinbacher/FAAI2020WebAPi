namespace FAAI2020WebAPI_Services
{
    using FAAI2020WebAPI_Contract.Services;

    public class CalcService : ICalcService
    {
        public double Add(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}

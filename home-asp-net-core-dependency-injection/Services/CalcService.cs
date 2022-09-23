namespace home_asp_net_core_dependency_injection.Services
{
    public class CalcService : ICalc
    {
        ICalc _calc;

        public CalcService(ICalc calc)
        {
            _calc = calc;
        }

        int ICalc.Dif()
        {
            return _calc.Dif();
        }

        int ICalc.Div()
        {
            return _calc.Div();
        }

        int ICalc.Mul()
        {
            return _calc.Mul();
        }

        int ICalc.Sum()
        {
            return _calc.Sum();
        }
    }
}

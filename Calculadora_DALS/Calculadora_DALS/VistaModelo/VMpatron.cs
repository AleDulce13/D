using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculadora_DALS.VistaModelo
{
    internal class VMpatron : BaseViewModel
    {
        #region VARIABLES

        string _N1;
        string _N2;
        string _R;

        #endregion

        #region CONTSRUCTOR

        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS

        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 + n2;
            R = r.ToString();
        }

        public void Restar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 - n2;
            R = r.ToString();
        }

        public void Multiplicar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 * n2;
            R = r.ToString();
        }


        public void Dividir()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 / n2;
            R = r.ToString();
        }

        public string R
        {
            get { return R; }
            set { SetValue(ref _R, value); }
        }

        #endregion
        #region PROCESOS

        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS

        public ICommand Sumarcommand => new Command(Sumar);
        public ICommand Restarrcommand => new Command(Restar);
        public ICommand Multiplicarcommand => new Command(Multiplicar);
        public ICommand Dividircommand => new Command(Dividir);
        #endregion

    }
}

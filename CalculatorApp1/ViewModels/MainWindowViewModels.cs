using CalculatorApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorApp1.ViewModels

{

    internal class MainWindowViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private string number;
        public string Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

        private string expression;
        public string Expression
        {
            get => expression;
            set
            {
                expression = value;
                OnPropertyChanged();
            }

        }
        public string operand;
        public double vr1;
        public double vr2;
        static double vr3;
        #region ввод чисел
        public ICommand Num0 { get; }
        public ICommand Num1 { get; }
        public ICommand Num2 { get; }
        public ICommand Num3 { get; }
        public ICommand Num4 { get; }
        public ICommand Num5 { get; }
        public ICommand Num6 { get; }
        public ICommand Num7 { get; }
        public ICommand Num8 { get; }
        public ICommand Num9 { get; }

        private void OnNum0Execute(object p)
        {
            Number += "0";

        }
        private bool CanNum0Executed(object p)
        {
            return true;
        }

        private void OnNum1Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "1";
        }
        private bool CanNum1Executed(object p)
        {
            return true;
        }

        private void OnNum2Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "2";
        }
        private bool CanNum2Executed(object p)
        {
            return true;
        }
        private void OnNum3Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "3";
        }
        private bool CanNum3Executed(object p)
        {
            
            return true;
        }
        private void OnNum4Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "4";
        }
        private bool CanNum4Executed(object p)
        {
            return true;
        }
        private void OnNum5Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "5";
        }
        private bool CanNum5Executed(object p)
        {
            return true;
        }
        private void OnNum6Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "6";
        }
        private bool CanNum6Executed(object p)
        {
            return true;
        }
        private void OnNum7Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "7";
        }
        private bool CanNum7Executed(object p)
        {
            return true;
        }
        private void OnNum8Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "8";
        }
        private bool CanNum8Executed(object p)
        {
            return true;
        }
        private void OnNum9Execute(object p)
        {
            GetDeleteValueTextBox(Number);
            Number += "9";
        }
        private bool CanNum9Executed(object p)
        {
            return true;
        }

        #endregion

        #region Мат. операции
        public ICommand Multi { get; }
        public ICommand Division { get; }
        public ICommand Addition { get; }
        public ICommand Substraction { get; }
        public ICommand Evenly { get; }
        public ICommand Onetoshare { get; }
        public ICommand Square { get; }
        public ICommand Rootofnumber { get; }
        public ICommand DecimalSign { get; }
        public ICommand DeleteValue { get; }


        private void OnMultiExecute(object p)
        {
            operand = "*";
            vr1 = Convert.ToDouble(Number);
            Number = null;
        }
        private bool CanMultiExecuted(object p)
        {
            return GetOffButton1(Number);
        }
        private void OnDivisionExecute(object p)
        {
            operand = "/";
            vr1 = Convert.ToDouble(Number);
            Number = null;
        }
        private bool CanDivisionExecuted(object p)
        {
            return GetOffButton1(Number);
        }
        private void OnAdditionExecute(object p)
        {
            operand = "+";
            vr1 = Convert.ToDouble(Number);
            Number = null;
        }
        private bool CanAdditionExecuted(object p)
        {
            return GetOffButton1(Number);
        }
        private void OnSubstractionExecute(object p)
        {
            operand = "-";
            vr1 = Convert.ToDouble(Number);
            Number = null;

        }
        private bool CanSubstractionExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnEvenlyExecute(object p)
        {
            vr2 = Convert.ToDouble(Number);
            expression = vr1.ToString()+operand+vr2.ToString()+" =";
            if (operand == "/" && vr2 == 0)
            {
                Number = "Деление на ноль";
            }
            else
            {
                vr3 = Ariph.Calculation(vr1, vr2, operand);
                Number = Convert.ToString(vr3);
            }
        }
        private bool CanEvenlyExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnOnetoshareExecute(object p)
        {
            operand = "1/x";
            vr1 = Convert.ToDouble(Number);
            if (vr1 != 0)
            {
                expression = $@"1/({vr1}) =";
                vr3 = Ariph.CalculationOneElement(vr1, operand);
                Number = Convert.ToString(vr3);
            }
            else
                Number = "Деление на ноль";

        }
        private bool CanOnetoshareExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnSquareExecute(object p)
        {
            operand = "x²";
            vr1 = Convert.ToDouble(Number);
            expression = $@"sqr({vr1}) =";
            vr3 = Ariph.CalculationOneElement(vr1, operand);
            Number = Convert.ToString(vr3);
        }
        private bool CanSquareExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnRootofnumberExecute(object p)
        {
            operand = "√x";
            vr1 = Convert.ToDouble(Number);
            expression = $@"√({vr1}) =";
            if (vr1 >= 0)
            {
                vr3 = Ariph.CalculationOneElement(vr1, operand);
                Number = Convert.ToString(vr3);
            }
            else
                Number = "Неверный ввод";
        }
        private bool CanRootExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnDecimalSignExecute(object p)
        {
            double z = Convert.ToDouble(Number);
            if (Convert.ToInt32(z) == z)
            {
                Number += ",";
            }
            else
                Number += "";

        }
        private bool CanDecimalSignExecuted(object p)
        {
            return GetOffButton1(Number);
        }

        private void OnDeleteValueExecute(object p)
        {
            Number = null;
            Expression = null;

        }
        private bool CanDeleteValueExecuted(object p)
        {
            return true;
        }
        #endregion
        public MainWindowViewModels()
        {
            Num0 = new RelayCommand(OnNum0Execute, CanNum0Executed);
            Num1 = new RelayCommand(OnNum1Execute, CanNum1Executed);
            Num2 = new RelayCommand(OnNum2Execute, CanNum2Executed);
            Num3 = new RelayCommand(OnNum3Execute, CanNum3Executed);
            Num4 = new RelayCommand(OnNum4Execute, CanNum4Executed);
            Num5 = new RelayCommand(OnNum5Execute, CanNum5Executed);
            Num6 = new RelayCommand(OnNum6Execute, CanNum6Executed);
            Num7 = new RelayCommand(OnNum7Execute, CanNum7Executed);
            Num8 = new RelayCommand(OnNum8Execute, CanNum8Executed);
            Num9 = new RelayCommand(OnNum9Execute, CanNum9Executed);
            Multi = new RelayCommand(OnMultiExecute, CanMultiExecuted);
            Division = new RelayCommand(OnDivisionExecute, CanDivisionExecuted);
            Addition = new RelayCommand(OnAdditionExecute, CanAdditionExecuted);
            Substraction = new RelayCommand(OnSubstractionExecute, CanSubstractionExecuted);
            Onetoshare = new RelayCommand(OnOnetoshareExecute, CanOnetoshareExecuted);
            Square = new RelayCommand(OnSquareExecute, CanSquareExecuted);
            Rootofnumber = new RelayCommand(OnRootofnumberExecute, CanRootExecuted);
            Evenly = new RelayCommand(OnEvenlyExecute, CanEvenlyExecuted);
            DecimalSign = new RelayCommand(OnDecimalSignExecute, CanDecimalSignExecuted);
            DeleteValue = new RelayCommand(OnDeleteValueExecute, CanDeleteValueExecuted);
        }
        /* Метод, блокирующий кнопки при деление ноль и извлечении корня из отрицательного числа */
        public bool GetOffButton1(string Number)
        {
            if (Number == "Деление на ноль" || Number == "Неверный ввод")
                return false;
            else
                return true;
        }

        /* Очищает поле */
        public void GetDeleteValueTextBox(string c)
        {
            if (c == "Деление на ноль" || c == "Неверный ввод")
                Number = null;
        }

    }
}

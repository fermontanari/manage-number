using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageNumber.Business
{
    /// <summary>
    /// Classe com as operações de um Number Management.
    /// </summary>
    public sealed class Operations
    {
        public const int TOTAL_NUMBERS = 15;
        public static IDictionary<string, DateTime> _ManageNumber = new Dictionary<string, DateTime>();

        /// <summary>
        /// Valida se a operação checkin pode ser realizada
        /// </summary>
        private static bool validateNumber(string number)
        {
            if (String.Equals(number.Trim(), string.Empty))
                throw new Exception(String.Format("Invalid Number.", number));

            if (_ManageNumber.Count == TOTAL_NUMBERS)
                throw new Exception("No numbers left!");

            if (_ManageNumber.ContainsKey(number))
                throw new Exception(String.Format("Number '{0} already exists!", number));

            return true;
        }

        /// <summary>
        /// Valida se a operação de checkout pode ser realizada
        /// </summary>
        private static bool validateCheckout(string number)
        { 
            if (String.Equals(number.Trim(), string.Empty))
                throw new Exception(String.Format("Invalid Number.", number));

            if (!_ManageNumber.ContainsKey(number))
                throw new Exception(String.Format("Number '{0}' does NOT exists!", number));

            return true;
        }

        /// <summary>
        /// Registra a entrada de um numero.
        /// </summary>
        public static void Checkin(string number)
        {
            validateNumber(number);
            _ManageNumber.Add(number, DateTime.Now);
            
        }

        /// <summary>
        /// Registra a saída de um numero.
        /// </summary>
        public static double Checkout(string number)
        {
            validateCheckout(number);
            DateTime entranceDate = _ManageNumber[number];

            _ManageNumber.Remove(number);

            return calculateFee(entranceDate, DateTime.Now);
        }

        /// <summary>
        /// Calcula o valor com base no tempo de permanência
        /// </summary>
        private static double calculateFee(DateTime entranceDate, DateTime now)
        {
            var permanencia = now.Subtract(entranceDate);
            return Math.Round((permanencia.TotalMinutes / 3), 2); // 3 reais é o valor mínimo
        }

    }
}

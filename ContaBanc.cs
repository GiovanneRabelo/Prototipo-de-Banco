using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoBanco {
    internal class ContaBanc {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } 

        public ContaBanc(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public ContaBanc(int numero, string titular, double depositoInicial): this (numero, titular) { 
            Deposito(depositoInicial);
        }
        public void Saque (double quantia) {
            Saldo -= quantia + 5.0;
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public override string ToString() {

            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $"
            + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

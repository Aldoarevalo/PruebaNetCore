namespace PruebaNetCore.Model
{
    public class TransferBanco
    {
        public long Id { get; set; }
        public string Banco_de_Origen  { get; set; }

        public string Banco_de_destino { get; set; }

        public string Cuenta_de_origen { get; set; }


        public string Cuenta_de_destino { get; set; }

        public string Fecha_operacion { get; set; }

        public string Monto_Operacion { get; set; }


        public string estado { get; set; }


    }

}

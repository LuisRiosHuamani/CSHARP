using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Final_01
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPapeletas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPapeletas
    {
        [OperationContract]
        List<PapeletaBE> ListarPapeleta();

        [OperationContract]
        List<PapeletaBE> ListarPapeletasPorFechas(DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<PapeletaBE> ListarPapeletasImpagas(String strCod);
    }

    [DataContract]
    [Serializable]
    public class PapeletaBE
    {
        private string _Num_Papeleta;
        private System.DateTime _Fec_Papeleta;
        private string _Cod_Infraccion;
        private string _Num_Placa;
        private string _Est_Papeleta;
        private string _Cod_Agente;

        [DataMember]
        public string Num_Papeleta
        {
            get { return this._Num_Papeleta; }
            set { this._Num_Papeleta = value; }
        }
        [DataMember]
        public System.DateTime Fec_Papeleta
        {
            get { return this._Fec_Papeleta; }
            set { this._Fec_Papeleta = value; }
        }
        [DataMember]
        public string Cod_Infraccion
        {
            get { return this._Cod_Infraccion; }
            set { this._Cod_Infraccion = value; }
        }
        [DataMember]
        public string Num_Placa
        {
            get { return this._Num_Placa; }
            set { this._Num_Placa = value; }
        }
        [DataMember]
        public string Est_Papeleta
        {
            get { return this._Est_Papeleta; }
            set { this._Est_Papeleta = value; }
        }
        [DataMember]
        public string Cod_Agente
        {
            get { return this._Cod_Agente; }
            set { this._Cod_Agente = value; }
        }
    }
}


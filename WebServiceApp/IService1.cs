using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceApp.DTO;

namespace WebServiceApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        // Listado 
        [OperationContract]
        List<TriangleDTO> ListTriangles();

        [OperationContract]
        List<SquareDTO> ListSquares();

        [OperationContract]
        List<CircleDTO> ListCircles();

        // Creacion
        [OperationContract]
        dynamic CreateTriangle(TriangleDTO Triangle);

        [OperationContract]
        dynamic CreateSquare(SquareDTO Square);
        
        [OperationContract]
        dynamic CreateCircle(CircleDTO Circle);

        // Consulta
        [OperationContract]
        TriangleDTO GetTriangleById(int ID);

        [OperationContract]
        SquareDTO GetSquareById(int Id);

        [OperationContract]
        CircleDTO GetCircleById(int Id);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

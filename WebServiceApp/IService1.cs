using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceApp.DTO;
using WebServiceApp.Models;

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
        List<RingDTO> ListRings();

        [OperationContract]
        List<RectangleDTO> ListRectangles();

        // Creacion
        [OperationContract]
        Triangle CreateTriangle(TriangleDTO Triangle);

        [OperationContract]
        Square CreateSquare(SquareDTO Square);
        
        [OperationContract]
        Ring CreateRing(RingDTO Ring);

        [OperationContract]
        Rectangle CreateRectangle(RectangleDTO Rectangle);

        // Consulta
        [OperationContract]
        TriangleDTO GetTriangleById(int ID);

        [OperationContract]
        SquareDTO GetSquareById(int Id);

        [OperationContract]
        RingDTO GetRingById(int Id);

        [OperationContract]
        RectangleDTO GetRectangleById(int Id);

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

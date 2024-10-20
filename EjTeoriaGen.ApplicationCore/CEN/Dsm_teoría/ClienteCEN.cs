

using System;
using System.Text;
using System.Collections.Generic;

using EjTeoriaGen.ApplicationCore.Exceptions;

using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;
using Newtonsoft.Json;


namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
/*
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteRepository _IClienteRepository;

public ClienteCEN(IClienteRepository _IClienteRepository)
{
        this._IClienteRepository = _IClienteRepository;
}

public IClienteRepository get_IClienteRepository ()
{
        return this._IClienteRepository;
}

public string Crear (string p_DNI, string p_nombre, string p_direccion, string p_telefono, String p_pass)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_DNI;

        clienteEN.Nombre = p_nombre;

        clienteEN.Direccion = p_direccion;

        clienteEN.Telefono = p_telefono;

        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);



        oid = _IClienteRepository.Crear (clienteEN);
        return oid;
}

public void Modificar (string p_Cliente_OID, string p_nombre, string p_direccion, string p_telefono, String p_pass)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Direccion = p_direccion;
        clienteEN.Telefono = p_telefono;
        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        //Call to ClienteRepository

        _IClienteRepository.Modificar (clienteEN);
}

public void Borrar (string DNI
                    )
{
        _IClienteRepository.Borrar (DNI);
}

public string Login (string p_Cliente_OID, string p_pass)
{
        string result = null;
        ClienteEN en = _IClienteRepository.ReadOIDDefault (p_Cliente_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.DNI);

        return result;
}

public ClienteEN DameOID (string DNI
                          )
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteRepository.DameOID (DNI);
        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> DameALL (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteRepository.DameALL (first, size);
        return list;
}



        private string Encode()
        {
            var payload = new Dictionary<string, object>()
            {
                { "exampleKey", "exampleValue" }
            };
            string token = Jose.JWT.Encode(payload, Utils.Util.getKey(), Jose.JwsAlgorithm.HS256);

            return token;
        }

public string GetToken (string DNI)
{
        ClienteEN en = _IClienteRepository.ReadOIDDefault (DNI);
        string token = Encode ();

        return token;
}
public string CheckToken (string token)
{
        string result = null;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                string id = (string)ObtenerDNI (decodedToken);

                ClienteEN en = _IClienteRepository.ReadOIDDefault (id);

                if (en != null && ((string)en.DNI).Equals (ObtenerDNI (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}

        private object ObtenerDNI(string decodedToken)
        {
            var tokenData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(decodedToken);
            ClienteEN en = new ClienteEN();
            en.DNI = tokenData.dni;
            return en.DNI;
        }
    }
}

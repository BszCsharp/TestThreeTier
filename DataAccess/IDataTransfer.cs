using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;

namespace DataAccess
{
    public interface IDataTransfer
    {

        bool ConnectToDb();

        List<GeraeteTyp> GetAllDeviceType();

        List<Geraet> GetAllDevices();

        bool CloseConnection();
    }
}

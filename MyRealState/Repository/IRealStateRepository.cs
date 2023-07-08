using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyRealState
{
    interface IRealStateRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactid);
        DataTable searche(string parameter);
        bool Insert(string nameorfamily, string phonenumber, string saleOrrent, int meterage, int price, string address, string description);
        bool Edit(int contactid,string nameorfamily, string phonenumber, string saleOrrent, int meterage, int price, string address, string description);
        bool Delete(int contactid);

    }
}

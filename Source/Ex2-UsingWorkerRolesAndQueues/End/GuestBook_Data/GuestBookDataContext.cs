using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Table.DataServices;

namespace GuestBook_Data
{
    public class GuestBookDataContext : Microsoft.WindowsAzure.Storage.Table.DataServices.TableServiceContext
    {
        public GuestBookDataContext(Microsoft.WindowsAzure.Storage.Table.CloudTableClient client)
            : base(client)
        {
        }
        
        public IQueryable<GuestBookEntry> GuestBookEntry
        {
            get
            {
                return this.CreateQuery<GuestBookEntry>("GuestBookEntry");
            }
        }
    }
}

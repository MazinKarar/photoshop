using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase
{
    public class InvoiceUtils
    {
        public static IEnumerable<InvoiceDetail> getInvoiceDetils(int invoiceID)
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.InvoiceDetails.Where(ctr => ctr.InvoiceId == invoiceID).ToList();
            }
        }
        public static int getIvoiceCount()
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.Invoices.Count();
            }

        }
        public static IEnumerable<Invoice> getAllInvoice()
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.Invoices.ToList();
            }

        }
        public static IEnumerable<InvoiceDetail> getInvoiceDetais(int invID)
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.InvoiceDetails.Where(i=> i.InvoiceId == invID).ToList();
            }

        }
        public static IEnumerable<SupplierSet> getAllSuppliers()
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.SupplierSets.ToList();
            }

        }
        public static IEnumerable<ItemGroup> getAllCategory()
        {//repositoryItemComboBox1
            using (var ctx = new AccountingSystem())
            {
                return ctx.ItemGroups.ToList();
            }
        }
        public static IEnumerable<Item> getAllProducts()
        {//repositoryItemComboBox1
            using (var ctx = new AccountingSystem())
            {
                return ctx.Items.ToList();
            }
        }
        public static IEnumerable<Item> getAllCategoryProducts(int catID)
        {//repositoryItemComboBox1
            using (var ctx = new AccountingSystem())
            {
                return ctx.Items.Where(ctr=>ctr.ItemGroupsId==catID).ToList();
            }
        }
        public static TObject Find<TObject>(int id)
            where TObject : class
        {
            using (var ctx = new AccountingSystem())
            {
                return ctx.Set<TObject>().Find(id);
            }
        }
        public static int Add<TEntity>(TEntity entity) {
            using (var ctx = new AccountingSystem())
            {
                //entity.cuid = LogTracker.GetLoggedUser().FullName;
                //entity.MakeCreated();
                ctx.Set(typeof(TEntity)).Add(entity);
                ctx.SaveChanges();
                return 0;
            }

        }

        public static int Update<TObject>( TObject obj)
            where TObject : class
        {
            using (var ctx = new AccountingSystem())
            {
                ctx.Set(typeof(TObject)).Attach(obj);
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return 0;
            }
        }
    }
    public class  InvoiceWorkflowState
    {
       public static long Request = 0;
       public static long Approvement = 1;
       public static long Payment = 2;
       public static long Return = 3;
       public static long Treasury = 4;
       public static long Completed = 5;
       public static long NotSet = 6;
       public static long Rejected = -1;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stregsystem
{
    ///<summary>A specification of <c>Transaction<c>, specifying a "deposit" transaction.</summary>
    class InsertCashTransaction : Transaction
    {
        ///<param name="user">The <c>User</c> depositing the money to their "account".</param>
        ///<param name="date">The date of the deposit</param>
        ///<param name="amount">The amount deposited</param>
        ///<summary>Constructor for the class, where it uses the base-class' constructor.</summary>
        public InsertCashTransaction(User user, DateTime date, float amount)
            : base(user, date, amount) { }

        ///<summary>Method for executing the transaction (Depositting the money).</summary>
        public override void Execute() => User.Balance += Amount;

        ///<summary>The <c>ToString</c>-method, used for logging the transaction.</summary>
        public override string ToString() => $"Transaction {ID} ({Date.ToString()}): {User.UserName} insterted {Amount.ToString()}.";
    }
}

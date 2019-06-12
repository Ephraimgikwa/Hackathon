using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
   public class Deposit
    {
       

        public int DepositAmount(int amount, int Balance)
        {
           int  newBalance = Balance + amount;

            Balance = newBalance;
            return (Balance);
        }

    }
}

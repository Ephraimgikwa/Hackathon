using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class Withdraw
    {

        //a function that withdraws money from account
        public int WithdrawAmount(int amount, int Balance)
        {
            int newBalance = Balance - amount;

            Balance = newBalance;
            return (Balance);
        }
    }
}

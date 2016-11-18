using System;

namespace OO{
    public class BankAccount{
        public void Withdraw(decimal amount){
            // put the logic here to make sure that it's enforced,
            // no matter where this component is used
            if(amount<0)
                throw new ArgumentException("Amount cannot be negative");
            if(amount>=balance)
                throw new ArgumentException("Amount exceeds balance limit");
            balance -= amount;
        }
        public void Deposit(decimal amount){ //methods are usually public
            // put the logic here to make sure that it's enforced,
            // no matter where this component is used
            if(amount<0)
                throw new ArgumentException("Amount cannot be negative");
            balance += amount;
        }

        
        private decimal balance; //fields are usually private. if they were public we would run the risk of unmonitored (and /or unauthorized) changes
        //property getter. this property is read only, we did not create the setter
        public decimal GetBalance(){
            return balance;
        }
        private string name; //private backing field
        
        //property setter
        public void SetName(string name){ 
            this.name = name; //we could enforce some rule here if necessary 
        }

        //property getter
        public string GetName(){
            return name;
        }
    }
}
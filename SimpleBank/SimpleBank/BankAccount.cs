using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private string _name;
        private double _balance;
        private bool _locked;

        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            _balance = balance;
            _locked = locked;
        }

        public BankAccount(string name, double balance) : this(name, balance, false) { }
        public BankAccount(double balance) : this("", balance, false) { }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public void Deposit(double amount)
        {
            if (_locked == false)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (_locked == false && amount <= _balance)
            {
                _balance -= amount;
            }
        }

        public void ChangeLockState()
        {
            _locked = !_locked;
        }

        public override string ToString()
        {
            return "Name: " + _name + ", Balance: " + _balance;
        }
    }
}

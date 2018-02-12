class BankAccount
    {
        private int id;
        private double balance;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public double Balance
        {
            get => balance;
            set => balance = value;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:f2}";
        }
}
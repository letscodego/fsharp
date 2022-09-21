module Transaction.Rules

open Transaction.Domain

module Accounts = 
    let deposit amount account = 
        {
            account with
                Balance = account.Balance + amount
        }

    let withdraw amount account = 
        {
            account with
                Balance = account.Balance - amount
        }
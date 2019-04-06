package banking;

import java.util.*;

import banking.exceptions.*;

// constructed using composition
public class Checking {

	private Account account;
	private static int nextCheckNbr = 100;
	private static ArrayList<Check> checks = new ArrayList<Check>();
	
	public void WriteCheck(String payee, double amount) throws InsufficientFundsException, DepositWithdrawTransferAmountNotPositiveException {
		Check check = new Check(nextCheckNbr++, new Date(), amount, this.getId(), payee);
		checks.add(check);
		this.withdraw(amount);
	}
	
	public int getId() {
		return account.getId();
	}
	public double getBalance() {
		return account.getBalance();
	}
	public String getDescription() {
		return account.getDescription();
	}
	public void setDescription(String newDescription) {
		account.setDescription(newDescription);
	}
	public void deposit(double amount) throws DepositWithdrawTransferAmountNotPositiveException {
		account.deposit(amount);
	}
	public void withdraw(double amount) throws InsufficientFundsException, DepositWithdrawTransferAmountNotPositiveException {
		account.withdraw(amount);
	}
	public boolean transferTo(Account toAccount, double amount) throws DepositWithdrawTransferAmountNotPositiveException {
		return account.transferTo(toAccount, amount);
	}
	
	public Checking(String newDescription) {
		account = new Account(newDescription);
	}
	public Checking() {
		account = new Account();
	}
}

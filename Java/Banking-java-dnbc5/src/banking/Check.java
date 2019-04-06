package banking;

import java.util.Date;

public class Check {

	private int nbr;
	private Date date;
	private double amount;
	private int accountId;
	private String payee;
	public int getNbr() {
		return nbr;
	}
	public Date getDate() {
		return date;
	}
	public double getAmount() {
		return amount;
	}
	public int getAccountId() {
		return accountId;
	}
	public String getPayee() {
		return payee;
	}
	private void setNbr(int nbr) {
		this.nbr = nbr;
	}
	private void setDate(Date date) {
		this.date = date;
	}
	private void setAmount(double amount) {
		this.amount = amount;
	}
	private void setAccountId(int accountId) {
		this.accountId = accountId;
	}
	private void setPayee(String payee) {
		this.payee = payee;
	}
	public Check(int nbr, Date date, double amount, int accountId, String payee) {
		this.nbr = nbr;
		this.date = date;
		this.amount = amount;
		this.accountId = accountId;
		this.payee = payee;
	}
	
	
}

# hello-world
public class CarLoan {
	public static void main(String[] args) {

	    int carLoan = 10000;
	    int loanLength = 3;
	    double interestRate = 0.05;
	    int downPayment = 2000; 
	    
	    if (loanLength <= 0 || interestRate <= 0) {
	    System.out.println("Error! you must take out a valid car loan"); \\verify how long the loan and the amount of interest
	     
	    } else if (downPayment >= carLoan) {
	      System.out.print("The car can be paid in full"); \\if the vehicle can be paid in full zero out the balance of the loan
	    }
	    else {
	      int remainingBalance = carLoan - downPayment;
	      int months = 36;
	      int monthlyBalance = remainingBalance / months;
	     double interest = monthlyBalance * 0.05 / 100;
	     double monthlyPayment = monthlyBalance + interest; \\ algorithm for calculating the monthly payments
	     
	      System.out.println("your monthly loan payment------------------------------------------" + monthlyPayment);{
	    }
	  }  
	}}


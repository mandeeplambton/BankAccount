using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//MandeepKaur(730387)
//Ramandeep Singh(732140)
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]


        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = -20.0;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBalance);

            //act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);

            }
        }
    }
using System;
using NUnit.Framework;

[TestFixture]
public class DummyTest
{
    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        //Arrange
        Axe axe = new Axe(5, 5);
        Dummy dummy = new Dummy(20, 20);

        //Act
        axe.Attack(dummy);
        axe.Attack(dummy);
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(5, dummy.Health, "Dummy not losing health.");

    }
    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Arrange
        Axe axe = new Axe(5, 5);
        Dummy dummy = new Dummy(20, 20);

        //Act
        axe.Attack(dummy);
        axe.Attack(dummy);
        axe.Attack(dummy);
        axe.Attack(dummy);

        //Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy),"Can't attack dead dummy.");
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        //Arrange
        Axe axe = new Axe(5, 5);
        Dummy dummy = new Dummy(3, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(10, dummy.GiveExperience(), "None XP given.");
    }

    [Test]
    public void AliveDummyCantGiveXP()
    {
        //Arrange
        Axe axe = new Axe(1, 20);
        Dummy dummy =new Dummy(20,20);

        //Act 
        axe.Attack(dummy);

        //Assert
        Assert.Throws<InvalidOperationException>(()=>dummy.GiveExperience(),"Dead dummy can't give XP.");
    }
}

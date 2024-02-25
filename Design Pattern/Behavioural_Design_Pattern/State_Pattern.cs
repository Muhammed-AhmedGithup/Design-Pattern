using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Behavioural_Design_Pattern
{
    internal class State_Pattern
    {
        public class PopMachine
        {
            private State idleState;
            private State hasOneDollarState;
            private State outOfStockState;
            private State currentState;
            private int count;
            public PopMachine(int count)
            {
                // make the needed states
                idleState = new IdleState();
                hasOneDollarState = new HasOneDollarState();
                outOfStockState = new OutOfStockState();
                if (count > 0)
                {
                    currentState = idleState;
                    this.count = count;
                }
                else
                {
                    currentState = outOfStockState;
                    this.count = 0;
                }
            }

        }
    }

    public interface State
    {
        public void insertDollar(VendingMachine vendingMachine
        );
        public void ejectMoney(VendingMachine vendingMachine);
        public void dispense(VendingMachine vendingMachine);
    }

    public class VendingMachine
    {
    }

    internal class HasOneDollarState:State
    {
        public HasOneDollarState()
        {
        }

        public void dispense(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void ejectMoney(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void insertDollar(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }

    internal class IdleState: State
    {
        public IdleState()
        {
        }

        public void dispense(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void ejectMoney(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void insertDollar(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }

    internal class OutOfStockState: State
    {
        public OutOfStockState()
        {
        }

        public void dispense(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void ejectMoney(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void insertDollar(VendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }
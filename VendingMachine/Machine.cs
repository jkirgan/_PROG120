using System;

namespace VendingMachine
{
    public class Machine
    {
        private int _Balance { get; set; } = 0;
        private int _MachineCap { get; set; } = 5;

        public int PubMachineCap
        {
            get { return _MachineCap; }
            
        }

        public int PubBalance
        {
            get { return _Balance; }
           
        }
        public int BuyCoke()
        {
            int header = 777;
            
            if (_Balance > 0 && _MachineCap > 0)
            {
                _Balance -= 1; 
                _MachineCap -= 1;
                return 1;
                
            }
            else if (_Balance == 0)
            {
                return 2;
            }
            else if (_MachineCap == 0)
            {

            }
            else if (_Balance == 0 && _MachineCap == 0)
            {
                
            }

            return header;

        }
        
        public void AcceptCash()
        {
            { _Balance +=1; }
        }

        public int GiveRefund()
        {

            if (_Balance > 0)
            {
                { _Balance -= _Balance; }
            }
            return 0;
        }
    }
}

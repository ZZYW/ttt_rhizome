
using UnityEngine;
namespace ThingSpace
{
    public class sowow : Thing
    {
        public override void Init()
        {

            //movement related
            speed = 4;
            seperation = 10;
            cohesion = 1;

            //shape and size            
            meshIndex = 26; //which geometry you want to use, range 0 - 43
            width = 3;
            height = 4;
            depth = 1;
            spikyness = 1;
            
            //color
            red = 0.6;
            green = Random(0, 2);
            blue = 0.1;            
            
        }

        public override void IntervalAction(Thing other)
        {
            //call a function like this
            Clone(other);
            
           

            //we can also use if statement to add a condition before an action
            //in this case we throw out a random number between 0 and 10, if it is bigger than 3, this Thing will Seek
            if (Random(0, 10) > 3)
            {
               Steal(other);
            }

        }

        public override void OnTouch(Thing other)
        {
            //another if statment, now it will see if the other Thing has more than 100 vertex, if yes, then Steal, else, Gift
            if (other.vertexCount > 509)
            {
                Clone(other);
            }
            else
            {
                Gift(other);
            }


        }

    }
}

            

using UnityEngine;
namespace ThingSpace
{
    public class anais : Thing
    {
        public override void Init()
        {

            //movement related
            speed = 1;
            seperation = 2;
            cohesion = 10;

            //shape and size            
            meshIndex = 30; //which geometry you want to use, range 0 - 43
            width = 2;
            height = 1;
            depth = 2;
            spikyness = 0;
            
            //color
            red = 1;
            green = Random(0, 2);
            blue = 0;            
            
        }

        public override void IntervalAction(Thing other)
        {
            //call a function like this
            //we can also use if statement to add a condition before an action
            //in this case we throw out a random number between 0 and 10, if it is bigger than 3, this Thing will Seek
            if (Random(0, 10) > 6)
            {
                Seek(other);
            }

        }

        public override void OnTouch(Thing other)
        {
            //another if statment, now it will see if the other Thing has more than 100 vertex, if yes, then Steal, else, Gift
            if (other.vertexCount > 100)
            {
                Steal(other);
            }
            else
            {
                Clone(other);
            }


        }

    }
}

            
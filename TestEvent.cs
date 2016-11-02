namespace DelegateAndEvent {
    public class TestEvent {
        public static void Main (string[] args) {
            RandomWalkerObserver obsA = new RandomWalkerObserver("obsA");
            RandomWalkerObserver obsB = new RandomWalkerObserver("obsB");

            RandomWalker walkerTom = new RandomWalker("Tom");
            RandomWalker walkerJane = new RandomWalker("Jane");

            MovedEventHandler d1 = new MovedEventHandler(obsA.Moved);
            d1 += new MovedEventHandler(obsB.Moved);
            walkerTom.Moved += d1;

            MovedEventHandler d2 = new MovedEventHandler(obsA.Moved);
            walkerJane.Moved += d2;

            for(int i = 0; i < 5; i++) {
                walkerTom.Move();
                walkerJane.Move();
            }
        }
    }
}

/************************************TEST OUTPUT***************************************

obsA: Subject Tom moved a step to the left
obsB: Subject Tom moved a step to the left
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the left
obsB: Subject Tom moved a step to the left
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the right
obsB: Subject Tom moved a step to the right
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the right
obsB: Subject Tom moved a step to the right
obsA: Subject Jane moved a step to the left
obsA: Subject Tom moved a step to the left
obsB: Subject Tom moved a step to the left
obsA: Subject Jane moved a step to the right

***********************************END TEST OUTPUT************************************/
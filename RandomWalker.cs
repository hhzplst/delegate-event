using System;

namespace DelegateAndEvent {

    public delegate void MovedEventHandler(RandomWalker subject, string direction);
    public class RandomWalker {
        public event MovedEventHandler Moved;
        Random r = new Random();
        public string SubjectName {get; set;}
        public RandomWalker(string name) {
            SubjectName = name;
        }
        private void OnMoved(string direction) {
         if (Moved != null)
            Moved(this, direction);
        }
        public void Move() {
            string direction = GetDirection();
            OnMoved(direction);
        }
        public string GetDirection() {
            double d = r.NextDouble();
            if (d < 0.5) return "left";
            else return "right";
        }
    }
}
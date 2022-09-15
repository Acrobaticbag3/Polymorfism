using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorfism {
    public class Shape {
        protected int width;
        protected int height;

        public Shape(int width, int height) {
            this.width = width;
            this.height = height;
        }

        public virtual void Circumferance() {
            
        }

        public virtual void Area() {
            
        }
    }
}
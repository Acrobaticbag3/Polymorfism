using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorfism {
    public class Shape {
        protected int _width;
        protected int _height;

        public Shape(int width, int height) {
            this._width = width;
            this._height = height;
        }

        public virtual void Circumferance() {
            
        }

        public virtual void Area() {
            
        }
    }
}
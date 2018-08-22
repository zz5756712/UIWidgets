﻿using UIWidgets.ui;

namespace UIWidgets.flow {
    public class OpacityLayer : ContainerLayer {
        private int _alpha;

        public int alpha {
            set { this._alpha = value; }
        }

        public override void paint(PaintContext context) {
            var canvas = context.canvas;

            var paint = new Paint {color = Color.fromARGB(this._alpha, 255, 255, 255)};
            canvas.saveLayer(this.paintBounds, paint);
            try {
                this.paintChildren(context);
            }
            finally {
                canvas.restore();
            }
        }
    }
}
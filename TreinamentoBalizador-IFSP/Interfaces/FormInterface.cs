﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBalizador_IFSP.Services
{
    interface FormInterface
    {
        void SetMovementLabel();
        void FinishCapture();
        void BodyDetected();
    }
}

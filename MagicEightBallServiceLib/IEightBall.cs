﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    [ServiceContract]
    public interface IEightBall
    {
        // Ask a question, receive an answer
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}

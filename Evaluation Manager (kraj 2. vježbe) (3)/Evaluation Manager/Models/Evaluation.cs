using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager.Models {
    public Evaluation 
    {

    public Activity Activity { get; set; }
    public Student Student { get; set; }
    public Teacher Teacher { get; set; }
    public DateTime EvaluationDate { get; set; },
    public int Point { get; set; }
    public bool IsSufficientForGrade (){
        return Points >= Activity.MinPointsForGrade;
    }

    public bool IsSufficientForSignature() {
        return Points >= Activity.MinPointForSignature;
    }
}
}

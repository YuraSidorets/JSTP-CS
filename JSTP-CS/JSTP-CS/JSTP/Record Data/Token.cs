using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jstp.Rd {
	enum Token : byte {
		TString         = 0,
		TNumber         = 1,
		TBracketOpen    = 2,
		TBracketClose   = 3,
		TTrue           = 4,
		TFalse          = 5,
		TComma          = 6,
		TNull           = 7,
		TNone           = 8
	}
}

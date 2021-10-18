using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Functions.Abs;
using ApiSdk.Workbooks.Item.Workbook.Functions.AccrInt;
using ApiSdk.Workbooks.Item.Workbook.Functions.AccrIntM;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acos;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acot;
using ApiSdk.Workbooks.Item.Workbook.Functions.Acoth;
using ApiSdk.Workbooks.Item.Workbook.Functions.AmorDegrc;
using ApiSdk.Workbooks.Item.Workbook.Functions.AmorLinc;
using ApiSdk.Workbooks.Item.Workbook.Functions.And;
using ApiSdk.Workbooks.Item.Workbook.Functions.Arabic;
using ApiSdk.Workbooks.Item.Workbook.Functions.Areas;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Asinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atan2;
using ApiSdk.Workbooks.Item.Workbook.Functions.Atanh;
using ApiSdk.Workbooks.Item.Workbook.Functions.AveDev;
using ApiSdk.Workbooks.Item.Workbook.Functions.Average;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageA;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.AverageIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.BahtText;
using ApiSdk.Workbooks.Item.Workbook.Functions.Base;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselI;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselJ;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselK;
using ApiSdk.Workbooks.Item.Workbook.Functions.BesselY;
using ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bin2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist_Range;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitand;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitlshift;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitrshift;
using ApiSdk.Workbooks.Item.Workbook.Functions.Bitxor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Math;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Char;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Choose;
using ApiSdk.Workbooks.Item.Workbook.Functions.Clean;
using ApiSdk.Workbooks.Item.Workbook.Functions.Code;
using ApiSdk.Workbooks.Item.Workbook.Functions.Columns;
using ApiSdk.Workbooks.Item.Workbook.Functions.Combin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Combina;
using ApiSdk.Workbooks.Item.Workbook.Functions.Complex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Concatenate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_Norm;
using ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_T;
using ApiSdk.Workbooks.Item.Workbook.Functions.Convert;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cos;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Cot;
using ApiSdk.Workbooks.Item.Workbook.Functions.Coth;
using ApiSdk.Workbooks.Item.Workbook.Functions.Count;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountA;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountBlank;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.CountIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDayBs;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDays;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupDaysNc;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupNcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.CoupPcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.Csc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Csch;
using ApiSdk.Workbooks.Item.Workbook.Functions.CumIPmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.CumPrinc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Date;
using ApiSdk.Workbooks.Item.Workbook.Functions.Datevalue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Daverage;
using ApiSdk.Workbooks.Item.Workbook.Functions.Day;
using ApiSdk.Workbooks.Item.Workbook.Functions.Days;
using ApiSdk.Workbooks.Item.Workbook.Functions.Days360;
using ApiSdk.Workbooks.Item.Workbook.Functions.Db;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dbcs;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dcount;
using ApiSdk.Workbooks.Item.Workbook.Functions.DcountA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ddb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dec2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Decimal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Degrees;
using ApiSdk.Workbooks.Item.Workbook.Functions.Delta;
using ApiSdk.Workbooks.Item.Workbook.Functions.DevSq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dget;
using ApiSdk.Workbooks.Item.Workbook.Functions.Disc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dmax;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dmin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dollar;
using ApiSdk.Workbooks.Item.Workbook.Functions.DollarDe;
using ApiSdk.Workbooks.Item.Workbook.Functions.DollarFr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dproduct;
using ApiSdk.Workbooks.Item.Workbook.Functions.DstDev;
using ApiSdk.Workbooks.Item.Workbook.Functions.DstDevP;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dsum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Duration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Dvar;
using ApiSdk.Workbooks.Item.Workbook.Functions.DvarP;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ecma_Ceiling;
using ApiSdk.Workbooks.Item.Workbook.Functions.Edate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Effect;
using ApiSdk.Workbooks.Item.Workbook.Functions.EoMonth;
using ApiSdk.Workbooks.Item.Workbook.Functions.Erf_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Erf;
using ApiSdk.Workbooks.Item.Workbook.Functions.ErfC_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.ErfC;
using ApiSdk.Workbooks.Item.Workbook.Functions.Error_Type;
using ApiSdk.Workbooks.Item.Workbook.Functions.Even;
using ApiSdk.Workbooks.Item.Workbook.Functions.Exact;
using ApiSdk.Workbooks.Item.Workbook.Functions.Exp;
using ApiSdk.Workbooks.Item.Workbook.Functions.Expon_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fact;
using ApiSdk.Workbooks.Item.Workbook.Functions.FactDouble;
using ApiSdk.Workbooks.Item.Workbook.Functions.False;
using ApiSdk.Workbooks.Item.Workbook.Functions.Find;
using ApiSdk.Workbooks.Item.Workbook.Functions.FindB;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fisher;
using ApiSdk.Workbooks.Item.Workbook.Functions.FisherInv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fixed;
using ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Math;
using ApiSdk.Workbooks.Item.Workbook.Functions.Floor_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Fvschedule;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gamma;
using ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn_Precise;
using ApiSdk.Workbooks.Item.Workbook.Functions.GammaLn;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gauss;
using ApiSdk.Workbooks.Item.Workbook.Functions.Gcd;
using ApiSdk.Workbooks.Item.Workbook.Functions.GeoMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.GeStep;
using ApiSdk.Workbooks.Item.Workbook.Functions.HarMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hex2Oct;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hlookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hour;
using ApiSdk.Workbooks.Item.Workbook.Functions.Hyperlink;
using ApiSdk.Workbooks.Item.Workbook.Functions.HypGeom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.If;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImAbs;
using ApiSdk.Workbooks.Item.Workbook.Functions.Imaginary;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImArgument;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImConjugate;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCos;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCosh;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCot;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCsc;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImCsch;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImDiv;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImExp;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLn;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLog10;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImLog2;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImPower;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImProduct;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImReal;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSec;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSech;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSin;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSqrt;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSub;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImSum;
using ApiSdk.Workbooks.Item.Workbook.Functions.ImTan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Int;
using ApiSdk.Workbooks.Item.Workbook.Functions.IntRate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ipmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Irr;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsErr;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsError;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsEven;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsFormula;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsLogical;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNA;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNonText;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsNumber;
using ApiSdk.Workbooks.Item.Workbook.Functions.Iso_Ceiling;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsOdd;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsoWeekNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ispmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Isref;
using ApiSdk.Workbooks.Item.Workbook.Functions.IsText;
using ApiSdk.Workbooks.Item.Workbook.Functions.Kurt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Large;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lcm;
using ApiSdk.Workbooks.Item.Workbook.Functions.Left;
using ApiSdk.Workbooks.Item.Workbook.Functions.Leftb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Len;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lenb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ln;
using ApiSdk.Workbooks.Item.Workbook.Functions.Log;
using ApiSdk.Workbooks.Item.Workbook.Functions.Log10;
using ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.LogNorm_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Lower;
using ApiSdk.Workbooks.Item.Workbook.Functions.Match;
using ApiSdk.Workbooks.Item.Workbook.Functions.Max;
using ApiSdk.Workbooks.Item.Workbook.Functions.MaxA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mduration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Median;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mid;
using ApiSdk.Workbooks.Item.Workbook.Functions.Midb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Min;
using ApiSdk.Workbooks.Item.Workbook.Functions.MinA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Minute;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mirr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mod;
using ApiSdk.Workbooks.Item.Workbook.Functions.Month;
using ApiSdk.Workbooks.Item.Workbook.Functions.Mround;
using ApiSdk.Workbooks.Item.Workbook.Functions.MultiNomial;
using ApiSdk.Workbooks.Item.Workbook.Functions.N;
using ApiSdk.Workbooks.Item.Workbook.Functions.Na;
using ApiSdk.Workbooks.Item.Workbook.Functions.NegBinom_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays_Intl;
using ApiSdk.Workbooks.Item.Workbook.Functions.NetworkDays;
using ApiSdk.Workbooks.Item.Workbook.Functions.Nominal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Norm_S_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Not;
using ApiSdk.Workbooks.Item.Workbook.Functions.Now;
using ApiSdk.Workbooks.Item.Workbook.Functions.Nper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Npv;
using ApiSdk.Workbooks.Item.Workbook.Functions.NumberValue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Bin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Dec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Oct2Hex;
using ApiSdk.Workbooks.Item.Workbook.Functions.Odd;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddFPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddFYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddLPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.OddLYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.Or;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pduration;
using ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Percentile_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PercentRank_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Permut;
using ApiSdk.Workbooks.Item.Workbook.Functions.Permutationa;
using ApiSdk.Workbooks.Item.Workbook.Functions.Phi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Poisson_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.Power;
using ApiSdk.Workbooks.Item.Workbook.Functions.Ppmt;
using ApiSdk.Workbooks.Item.Workbook.Functions.Price;
using ApiSdk.Workbooks.Item.Workbook.Functions.PriceDisc;
using ApiSdk.Workbooks.Item.Workbook.Functions.PriceMat;
using ApiSdk.Workbooks.Item.Workbook.Functions.Product;
using ApiSdk.Workbooks.Item.Workbook.Functions.Proper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Pv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Exc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quartile_Inc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Quotient;
using ApiSdk.Workbooks.Item.Workbook.Functions.Radians;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rand;
using ApiSdk.Workbooks.Item.Workbook.Functions.RandBetween;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Avg;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Eq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rate;
using ApiSdk.Workbooks.Item.Workbook.Functions.Received;
using ApiSdk.Workbooks.Item.Workbook.Functions.Replace;
using ApiSdk.Workbooks.Item.Workbook.Functions.ReplaceB;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rept;
using ApiSdk.Workbooks.Item.Workbook.Functions.Right;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rightb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Roman;
using ApiSdk.Workbooks.Item.Workbook.Functions.Round;
using ApiSdk.Workbooks.Item.Workbook.Functions.RoundDown;
using ApiSdk.Workbooks.Item.Workbook.Functions.RoundUp;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rows;
using ApiSdk.Workbooks.Item.Workbook.Functions.Rri;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sec;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sech;
using ApiSdk.Workbooks.Item.Workbook.Functions.Second;
using ApiSdk.Workbooks.Item.Workbook.Functions.SeriesSum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sheet;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sheets;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sign;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sin;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sinh;
using ApiSdk.Workbooks.Item.Workbook.Functions.Skew_p;
using ApiSdk.Workbooks.Item.Workbook.Functions.Skew;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sln;
using ApiSdk.Workbooks.Item.Workbook.Functions.Small;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sqrt;
using ApiSdk.Workbooks.Item.Workbook.Functions.SqrtPi;
using ApiSdk.Workbooks.Item.Workbook.Functions.Standardize;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDev_P;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDev_S;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDevA;
using ApiSdk.Workbooks.Item.Workbook.Functions.StDevPA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Substitute;
using ApiSdk.Workbooks.Item.Workbook.Functions.Subtotal;
using ApiSdk.Workbooks.Item.Workbook.Functions.Sum;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumIf;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumIfs;
using ApiSdk.Workbooks.Item.Workbook.Functions.SumSq;
using ApiSdk.Workbooks.Item.Workbook.Functions.Syd;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_2T;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_RT;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv_2T;
using ApiSdk.Workbooks.Item.Workbook.Functions.T_Inv;
using ApiSdk.Workbooks.Item.Workbook.Functions.T;
using ApiSdk.Workbooks.Item.Workbook.Functions.Tan;
using ApiSdk.Workbooks.Item.Workbook.Functions.Tanh;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillEq;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillPrice;
using ApiSdk.Workbooks.Item.Workbook.Functions.TbillYield;
using ApiSdk.Workbooks.Item.Workbook.Functions.Text;
using ApiSdk.Workbooks.Item.Workbook.Functions.Time;
using ApiSdk.Workbooks.Item.Workbook.Functions.Timevalue;
using ApiSdk.Workbooks.Item.Workbook.Functions.Today;
using ApiSdk.Workbooks.Item.Workbook.Functions.Trim;
using ApiSdk.Workbooks.Item.Workbook.Functions.TrimMean;
using ApiSdk.Workbooks.Item.Workbook.Functions.True;
using ApiSdk.Workbooks.Item.Workbook.Functions.Trunc;
using ApiSdk.Workbooks.Item.Workbook.Functions.Type;
using ApiSdk.Workbooks.Item.Workbook.Functions.Unichar;
using ApiSdk.Workbooks.Item.Workbook.Functions.Unicode;
using ApiSdk.Workbooks.Item.Workbook.Functions.Upper;
using ApiSdk.Workbooks.Item.Workbook.Functions.Usdollar;
using ApiSdk.Workbooks.Item.Workbook.Functions.Value;
using ApiSdk.Workbooks.Item.Workbook.Functions.Var_P;
using ApiSdk.Workbooks.Item.Workbook.Functions.Var_S;
using ApiSdk.Workbooks.Item.Workbook.Functions.VarA;
using ApiSdk.Workbooks.Item.Workbook.Functions.VarPA;
using ApiSdk.Workbooks.Item.Workbook.Functions.Vdb;
using ApiSdk.Workbooks.Item.Workbook.Functions.Vlookup;
using ApiSdk.Workbooks.Item.Workbook.Functions.Weekday;
using ApiSdk.Workbooks.Item.Workbook.Functions.WeekNum;
using ApiSdk.Workbooks.Item.Workbook.Functions.Weibull_Dist;
using ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay_Intl;
using ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xirr;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xnpv;
using ApiSdk.Workbooks.Item.Workbook.Functions.Xor;
using ApiSdk.Workbooks.Item.Workbook.Functions.Year;
using ApiSdk.Workbooks.Item.Workbook.Functions.YearFrac;
using ApiSdk.Workbooks.Item.Workbook.Functions.Yield;
using ApiSdk.Workbooks.Item.Workbook.Functions.YieldDisc;
using ApiSdk.Workbooks.Item.Workbook.Functions.YieldMat;
using ApiSdk.Workbooks.Item.Workbook.Functions.Z_Test;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook.Functions {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\functions</summary>
    public class FunctionsRequestBuilder {
        public AbsRequestBuilder Abs { get =>
            new AbsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AccrIntRequestBuilder AccrInt { get =>
            new AccrIntRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AccrIntMRequestBuilder AccrIntM { get =>
            new AccrIntMRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AcosRequestBuilder Acos { get =>
            new AcosRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AcoshRequestBuilder Acosh { get =>
            new AcoshRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AcotRequestBuilder Acot { get =>
            new AcotRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AcothRequestBuilder Acoth { get =>
            new AcothRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AmorDegrcRequestBuilder AmorDegrc { get =>
            new AmorDegrcRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AmorLincRequestBuilder AmorLinc { get =>
            new AmorLincRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AndRequestBuilder And { get =>
            new AndRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ArabicRequestBuilder Arabic { get =>
            new ArabicRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AreasRequestBuilder Areas { get =>
            new AreasRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AscRequestBuilder Asc { get =>
            new AscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AsinRequestBuilder Asin { get =>
            new AsinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AsinhRequestBuilder Asinh { get =>
            new AsinhRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AtanRequestBuilder Atan { get =>
            new AtanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Atan2RequestBuilder Atan2 { get =>
            new Atan2RequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AtanhRequestBuilder Atanh { get =>
            new AtanhRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AveDevRequestBuilder AveDev { get =>
            new AveDevRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AverageRequestBuilder Average { get =>
            new AverageRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AverageARequestBuilder AverageA { get =>
            new AverageARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AverageIfRequestBuilder AverageIf { get =>
            new AverageIfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AverageIfsRequestBuilder AverageIfs { get =>
            new AverageIfsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BahtTextRequestBuilder BahtText { get =>
            new BahtTextRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BaseRequestBuilder Base { get =>
            new BaseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BesselIRequestBuilder BesselI { get =>
            new BesselIRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BesselJRequestBuilder BesselJ { get =>
            new BesselJRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BesselKRequestBuilder BesselK { get =>
            new BesselKRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BesselYRequestBuilder BesselY { get =>
            new BesselYRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Beta_DistRequestBuilder Beta_Dist { get =>
            new Beta_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Beta_InvRequestBuilder Beta_Inv { get =>
            new Beta_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Bin2DecRequestBuilder Bin2Dec { get =>
            new Bin2DecRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Bin2HexRequestBuilder Bin2Hex { get =>
            new Bin2HexRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Bin2OctRequestBuilder Bin2Oct { get =>
            new Bin2OctRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Binom_DistRequestBuilder Binom_Dist { get =>
            new Binom_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Binom_Dist_RangeRequestBuilder Binom_Dist_Range { get =>
            new Binom_Dist_RangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Binom_InvRequestBuilder Binom_Inv { get =>
            new Binom_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BitandRequestBuilder Bitand { get =>
            new BitandRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BitlshiftRequestBuilder Bitlshift { get =>
            new BitlshiftRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BitorRequestBuilder Bitor { get =>
            new BitorRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BitrshiftRequestBuilder Bitrshift { get =>
            new BitrshiftRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public BitxorRequestBuilder Bitxor { get =>
            new BitxorRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Ceiling_MathRequestBuilder Ceiling_Math { get =>
            new Ceiling_MathRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Ceiling_PreciseRequestBuilder Ceiling_Precise { get =>
            new Ceiling_PreciseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CharRequestBuilder Char { get =>
            new CharRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChiSq_DistRequestBuilder ChiSq_Dist { get =>
            new ChiSq_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChiSq_Dist_RTRequestBuilder ChiSq_Dist_RT { get =>
            new ChiSq_Dist_RTRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChiSq_InvRequestBuilder ChiSq_Inv { get =>
            new ChiSq_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChiSq_Inv_RTRequestBuilder ChiSq_Inv_RT { get =>
            new ChiSq_Inv_RTRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChooseRequestBuilder Choose { get =>
            new ChooseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CleanRequestBuilder Clean { get =>
            new CleanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CodeRequestBuilder Code { get =>
            new CodeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CombinRequestBuilder Combin { get =>
            new CombinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CombinaRequestBuilder Combina { get =>
            new CombinaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ComplexRequestBuilder Complex { get =>
            new ComplexRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ConcatenateRequestBuilder Concatenate { get =>
            new ConcatenateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Confidence_NormRequestBuilder Confidence_Norm { get =>
            new Confidence_NormRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Confidence_TRequestBuilder Confidence_T { get =>
            new Confidence_TRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ConvertRequestBuilder Convert { get =>
            new ConvertRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CosRequestBuilder Cos { get =>
            new CosRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoshRequestBuilder Cosh { get =>
            new CoshRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CotRequestBuilder Cot { get =>
            new CotRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CothRequestBuilder Coth { get =>
            new CothRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CountARequestBuilder CountA { get =>
            new CountARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CountBlankRequestBuilder CountBlank { get =>
            new CountBlankRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CountIfRequestBuilder CountIf { get =>
            new CountIfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CountIfsRequestBuilder CountIfs { get =>
            new CountIfsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupDayBsRequestBuilder CoupDayBs { get =>
            new CoupDayBsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupDaysRequestBuilder CoupDays { get =>
            new CoupDaysRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupDaysNcRequestBuilder CoupDaysNc { get =>
            new CoupDaysNcRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupNcdRequestBuilder CoupNcd { get =>
            new CoupNcdRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupNumRequestBuilder CoupNum { get =>
            new CoupNumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CoupPcdRequestBuilder CoupPcd { get =>
            new CoupPcdRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CscRequestBuilder Csc { get =>
            new CscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CschRequestBuilder Csch { get =>
            new CschRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CumIPmtRequestBuilder CumIPmt { get =>
            new CumIPmtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CumPrincRequestBuilder CumPrinc { get =>
            new CumPrincRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DateRequestBuilder Date { get =>
            new DateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DatevalueRequestBuilder Datevalue { get =>
            new DatevalueRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DaverageRequestBuilder Daverage { get =>
            new DaverageRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DayRequestBuilder Day { get =>
            new DayRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DaysRequestBuilder Days { get =>
            new DaysRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Days360RequestBuilder Days360 { get =>
            new Days360RequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DbRequestBuilder Db { get =>
            new DbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DbcsRequestBuilder Dbcs { get =>
            new DbcsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DcountRequestBuilder Dcount { get =>
            new DcountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DcountARequestBuilder DcountA { get =>
            new DcountARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DdbRequestBuilder Ddb { get =>
            new DdbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Dec2BinRequestBuilder Dec2Bin { get =>
            new Dec2BinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Dec2HexRequestBuilder Dec2Hex { get =>
            new Dec2HexRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Dec2OctRequestBuilder Dec2Oct { get =>
            new Dec2OctRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DecimalRequestBuilder Decimal { get =>
            new DecimalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DegreesRequestBuilder Degrees { get =>
            new DegreesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeltaRequestBuilder Delta { get =>
            new DeltaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DevSqRequestBuilder DevSq { get =>
            new DevSqRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DgetRequestBuilder Dget { get =>
            new DgetRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DiscRequestBuilder Disc { get =>
            new DiscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DmaxRequestBuilder Dmax { get =>
            new DmaxRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DminRequestBuilder Dmin { get =>
            new DminRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DollarRequestBuilder Dollar { get =>
            new DollarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DollarDeRequestBuilder DollarDe { get =>
            new DollarDeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DollarFrRequestBuilder DollarFr { get =>
            new DollarFrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DproductRequestBuilder Dproduct { get =>
            new DproductRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DstDevRequestBuilder DstDev { get =>
            new DstDevRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DstDevPRequestBuilder DstDevP { get =>
            new DstDevPRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DsumRequestBuilder Dsum { get =>
            new DsumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DurationRequestBuilder Duration { get =>
            new DurationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DvarRequestBuilder Dvar { get =>
            new DvarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DvarPRequestBuilder DvarP { get =>
            new DvarPRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Ecma_CeilingRequestBuilder Ecma_Ceiling { get =>
            new Ecma_CeilingRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EdateRequestBuilder Edate { get =>
            new EdateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EffectRequestBuilder Effect { get =>
            new EffectRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EoMonthRequestBuilder EoMonth { get =>
            new EoMonthRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ErfRequestBuilder Erf { get =>
            new ErfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Erf_PreciseRequestBuilder Erf_Precise { get =>
            new Erf_PreciseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ErfCRequestBuilder ErfC { get =>
            new ErfCRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ErfC_PreciseRequestBuilder ErfC_Precise { get =>
            new ErfC_PreciseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Error_TypeRequestBuilder Error_Type { get =>
            new Error_TypeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EvenRequestBuilder Even { get =>
            new EvenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExactRequestBuilder Exact { get =>
            new ExactRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExpRequestBuilder Exp { get =>
            new ExpRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Expon_DistRequestBuilder Expon_Dist { get =>
            new Expon_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public F_DistRequestBuilder F_Dist { get =>
            new F_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public F_Dist_RTRequestBuilder F_Dist_RT { get =>
            new F_Dist_RTRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public F_InvRequestBuilder F_Inv { get =>
            new F_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public F_Inv_RTRequestBuilder F_Inv_RT { get =>
            new F_Inv_RTRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FactRequestBuilder Fact { get =>
            new FactRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FactDoubleRequestBuilder FactDouble { get =>
            new FactDoubleRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FalseRequestBuilder False { get =>
            new FalseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FindRequestBuilder Find { get =>
            new FindRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FindBRequestBuilder FindB { get =>
            new FindBRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FisherRequestBuilder Fisher { get =>
            new FisherRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FisherInvRequestBuilder FisherInv { get =>
            new FisherInvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FixedRequestBuilder Fixed { get =>
            new FixedRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Floor_MathRequestBuilder Floor_Math { get =>
            new Floor_MathRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Floor_PreciseRequestBuilder Floor_Precise { get =>
            new Floor_PreciseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FvRequestBuilder Fv { get =>
            new FvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FvscheduleRequestBuilder Fvschedule { get =>
            new FvscheduleRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GammaRequestBuilder Gamma { get =>
            new GammaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Gamma_DistRequestBuilder Gamma_Dist { get =>
            new Gamma_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Gamma_InvRequestBuilder Gamma_Inv { get =>
            new Gamma_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GammaLnRequestBuilder GammaLn { get =>
            new GammaLnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GammaLn_PreciseRequestBuilder GammaLn_Precise { get =>
            new GammaLn_PreciseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GaussRequestBuilder Gauss { get =>
            new GaussRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GcdRequestBuilder Gcd { get =>
            new GcdRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GeoMeanRequestBuilder GeoMean { get =>
            new GeoMeanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GeStepRequestBuilder GeStep { get =>
            new GeStepRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HarMeanRequestBuilder HarMean { get =>
            new HarMeanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Hex2BinRequestBuilder Hex2Bin { get =>
            new Hex2BinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Hex2DecRequestBuilder Hex2Dec { get =>
            new Hex2DecRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Hex2OctRequestBuilder Hex2Oct { get =>
            new Hex2OctRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HlookupRequestBuilder Hlookup { get =>
            new HlookupRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HourRequestBuilder Hour { get =>
            new HourRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HyperlinkRequestBuilder Hyperlink { get =>
            new HyperlinkRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HypGeom_DistRequestBuilder HypGeom_Dist { get =>
            new HypGeom_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IfRequestBuilder If { get =>
            new IfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImAbsRequestBuilder ImAbs { get =>
            new ImAbsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImaginaryRequestBuilder Imaginary { get =>
            new ImaginaryRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImArgumentRequestBuilder ImArgument { get =>
            new ImArgumentRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImConjugateRequestBuilder ImConjugate { get =>
            new ImConjugateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImCosRequestBuilder ImCos { get =>
            new ImCosRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImCoshRequestBuilder ImCosh { get =>
            new ImCoshRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImCotRequestBuilder ImCot { get =>
            new ImCotRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImCscRequestBuilder ImCsc { get =>
            new ImCscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImCschRequestBuilder ImCsch { get =>
            new ImCschRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImDivRequestBuilder ImDiv { get =>
            new ImDivRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImExpRequestBuilder ImExp { get =>
            new ImExpRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImLnRequestBuilder ImLn { get =>
            new ImLnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImLog10RequestBuilder ImLog10 { get =>
            new ImLog10RequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImLog2RequestBuilder ImLog2 { get =>
            new ImLog2RequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImPowerRequestBuilder ImPower { get =>
            new ImPowerRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImProductRequestBuilder ImProduct { get =>
            new ImProductRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImRealRequestBuilder ImReal { get =>
            new ImRealRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSecRequestBuilder ImSec { get =>
            new ImSecRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSechRequestBuilder ImSech { get =>
            new ImSechRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSinRequestBuilder ImSin { get =>
            new ImSinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSinhRequestBuilder ImSinh { get =>
            new ImSinhRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSqrtRequestBuilder ImSqrt { get =>
            new ImSqrtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSubRequestBuilder ImSub { get =>
            new ImSubRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImSumRequestBuilder ImSum { get =>
            new ImSumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImTanRequestBuilder ImTan { get =>
            new ImTanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IntRequestBuilder Int { get =>
            new IntRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IntRateRequestBuilder IntRate { get =>
            new IntRateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IpmtRequestBuilder Ipmt { get =>
            new IpmtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IrrRequestBuilder Irr { get =>
            new IrrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsErrRequestBuilder IsErr { get =>
            new IsErrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsErrorRequestBuilder IsError { get =>
            new IsErrorRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsEvenRequestBuilder IsEven { get =>
            new IsEvenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsFormulaRequestBuilder IsFormula { get =>
            new IsFormulaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsLogicalRequestBuilder IsLogical { get =>
            new IsLogicalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsNARequestBuilder IsNA { get =>
            new IsNARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsNonTextRequestBuilder IsNonText { get =>
            new IsNonTextRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsNumberRequestBuilder IsNumber { get =>
            new IsNumberRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Iso_CeilingRequestBuilder Iso_Ceiling { get =>
            new Iso_CeilingRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsOddRequestBuilder IsOdd { get =>
            new IsOddRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsoWeekNumRequestBuilder IsoWeekNum { get =>
            new IsoWeekNumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IspmtRequestBuilder Ispmt { get =>
            new IspmtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public IsrefRequestBuilder Isref { get =>
            new IsrefRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IsTextRequestBuilder IsText { get =>
            new IsTextRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public KurtRequestBuilder Kurt { get =>
            new KurtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LargeRequestBuilder Large { get =>
            new LargeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LcmRequestBuilder Lcm { get =>
            new LcmRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LeftRequestBuilder Left { get =>
            new LeftRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LeftbRequestBuilder Leftb { get =>
            new LeftbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LenRequestBuilder Len { get =>
            new LenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LenbRequestBuilder Lenb { get =>
            new LenbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LnRequestBuilder Ln { get =>
            new LnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LogRequestBuilder Log { get =>
            new LogRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Log10RequestBuilder Log10 { get =>
            new Log10RequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LogNorm_DistRequestBuilder LogNorm_Dist { get =>
            new LogNorm_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LogNorm_InvRequestBuilder LogNorm_Inv { get =>
            new LogNorm_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LookupRequestBuilder Lookup { get =>
            new LookupRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LowerRequestBuilder Lower { get =>
            new LowerRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MatchRequestBuilder Match { get =>
            new MatchRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MaxRequestBuilder Max { get =>
            new MaxRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MaxARequestBuilder MaxA { get =>
            new MaxARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MdurationRequestBuilder Mduration { get =>
            new MdurationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MedianRequestBuilder Median { get =>
            new MedianRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MidRequestBuilder Mid { get =>
            new MidRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MidbRequestBuilder Midb { get =>
            new MidbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MinRequestBuilder Min { get =>
            new MinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MinARequestBuilder MinA { get =>
            new MinARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MinuteRequestBuilder Minute { get =>
            new MinuteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MirrRequestBuilder Mirr { get =>
            new MirrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ModRequestBuilder Mod { get =>
            new ModRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MonthRequestBuilder Month { get =>
            new MonthRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MroundRequestBuilder Mround { get =>
            new MroundRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MultiNomialRequestBuilder MultiNomial { get =>
            new MultiNomialRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NRequestBuilder N { get =>
            new NRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NaRequestBuilder Na { get =>
            new NaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NegBinom_DistRequestBuilder NegBinom_Dist { get =>
            new NegBinom_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NetworkDaysRequestBuilder NetworkDays { get =>
            new NetworkDaysRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NetworkDays_IntlRequestBuilder NetworkDays_Intl { get =>
            new NetworkDays_IntlRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NominalRequestBuilder Nominal { get =>
            new NominalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Norm_DistRequestBuilder Norm_Dist { get =>
            new Norm_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Norm_InvRequestBuilder Norm_Inv { get =>
            new Norm_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Norm_S_DistRequestBuilder Norm_S_Dist { get =>
            new Norm_S_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Norm_S_InvRequestBuilder Norm_S_Inv { get =>
            new Norm_S_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NotRequestBuilder Not { get =>
            new NotRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NowRequestBuilder Now { get =>
            new NowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NperRequestBuilder Nper { get =>
            new NperRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NpvRequestBuilder Npv { get =>
            new NpvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NumberValueRequestBuilder NumberValue { get =>
            new NumberValueRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Oct2BinRequestBuilder Oct2Bin { get =>
            new Oct2BinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Oct2DecRequestBuilder Oct2Dec { get =>
            new Oct2DecRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Oct2HexRequestBuilder Oct2Hex { get =>
            new Oct2HexRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OddRequestBuilder Odd { get =>
            new OddRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OddFPriceRequestBuilder OddFPrice { get =>
            new OddFPriceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OddFYieldRequestBuilder OddFYield { get =>
            new OddFYieldRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OddLPriceRequestBuilder OddLPrice { get =>
            new OddLPriceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OddLYieldRequestBuilder OddLYield { get =>
            new OddLYieldRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OrRequestBuilder Or { get =>
            new OrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PdurationRequestBuilder Pduration { get =>
            new PdurationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Percentile_ExcRequestBuilder Percentile_Exc { get =>
            new Percentile_ExcRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Percentile_IncRequestBuilder Percentile_Inc { get =>
            new Percentile_IncRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PercentRank_ExcRequestBuilder PercentRank_Exc { get =>
            new PercentRank_ExcRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PercentRank_IncRequestBuilder PercentRank_Inc { get =>
            new PercentRank_IncRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PermutRequestBuilder Permut { get =>
            new PermutRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PermutationaRequestBuilder Permutationa { get =>
            new PermutationaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PhiRequestBuilder Phi { get =>
            new PhiRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PiRequestBuilder Pi { get =>
            new PiRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PmtRequestBuilder Pmt { get =>
            new PmtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Poisson_DistRequestBuilder Poisson_Dist { get =>
            new Poisson_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PowerRequestBuilder Power { get =>
            new PowerRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PpmtRequestBuilder Ppmt { get =>
            new PpmtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PriceRequestBuilder Price { get =>
            new PriceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PriceDiscRequestBuilder PriceDisc { get =>
            new PriceDiscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PriceMatRequestBuilder PriceMat { get =>
            new PriceMatRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ProductRequestBuilder Product { get =>
            new ProductRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ProperRequestBuilder Proper { get =>
            new ProperRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PvRequestBuilder Pv { get =>
            new PvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Quartile_ExcRequestBuilder Quartile_Exc { get =>
            new Quartile_ExcRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Quartile_IncRequestBuilder Quartile_Inc { get =>
            new Quartile_IncRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public QuotientRequestBuilder Quotient { get =>
            new QuotientRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RadiansRequestBuilder Radians { get =>
            new RadiansRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RandRequestBuilder Rand { get =>
            new RandRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RandBetweenRequestBuilder RandBetween { get =>
            new RandBetweenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Rank_AvgRequestBuilder Rank_Avg { get =>
            new Rank_AvgRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Rank_EqRequestBuilder Rank_Eq { get =>
            new Rank_EqRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RateRequestBuilder Rate { get =>
            new RateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReceivedRequestBuilder Received { get =>
            new ReceivedRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReplaceRequestBuilder Replace { get =>
            new ReplaceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReplaceBRequestBuilder ReplaceB { get =>
            new ReplaceBRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReptRequestBuilder Rept { get =>
            new ReptRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RightRequestBuilder Right { get =>
            new RightRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RightbRequestBuilder Rightb { get =>
            new RightbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RomanRequestBuilder Roman { get =>
            new RomanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RoundRequestBuilder Round { get =>
            new RoundRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RoundDownRequestBuilder RoundDown { get =>
            new RoundDownRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RoundUpRequestBuilder RoundUp { get =>
            new RoundUpRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RowsRequestBuilder Rows { get =>
            new RowsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RriRequestBuilder Rri { get =>
            new RriRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SecRequestBuilder Sec { get =>
            new SecRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SechRequestBuilder Sech { get =>
            new SechRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SecondRequestBuilder Second { get =>
            new SecondRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SeriesSumRequestBuilder SeriesSum { get =>
            new SeriesSumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SheetRequestBuilder Sheet { get =>
            new SheetRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SheetsRequestBuilder Sheets { get =>
            new SheetsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SignRequestBuilder Sign { get =>
            new SignRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SinRequestBuilder Sin { get =>
            new SinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SinhRequestBuilder Sinh { get =>
            new SinhRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SkewRequestBuilder Skew { get =>
            new SkewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Skew_pRequestBuilder Skew_p { get =>
            new Skew_pRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SlnRequestBuilder Sln { get =>
            new SlnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SmallRequestBuilder Small { get =>
            new SmallRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SqrtRequestBuilder Sqrt { get =>
            new SqrtRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SqrtPiRequestBuilder SqrtPi { get =>
            new SqrtPiRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public StandardizeRequestBuilder Standardize { get =>
            new StandardizeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public StDev_PRequestBuilder StDev_P { get =>
            new StDev_PRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public StDev_SRequestBuilder StDev_S { get =>
            new StDev_SRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public StDevARequestBuilder StDevA { get =>
            new StDevARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public StDevPARequestBuilder StDevPA { get =>
            new StDevPARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SubstituteRequestBuilder Substitute { get =>
            new SubstituteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SubtotalRequestBuilder Subtotal { get =>
            new SubtotalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SumRequestBuilder Sum { get =>
            new SumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SumIfRequestBuilder SumIf { get =>
            new SumIfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SumIfsRequestBuilder SumIfs { get =>
            new SumIfsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SumSqRequestBuilder SumSq { get =>
            new SumSqRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SydRequestBuilder Syd { get =>
            new SydRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TRequestBuilder T { get =>
            new TRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public T_DistRequestBuilder T_Dist { get =>
            new T_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public T_Dist_2TRequestBuilder T_Dist_2T { get =>
            new T_Dist_2TRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public T_Dist_RTRequestBuilder T_Dist_RT { get =>
            new T_Dist_RTRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public T_InvRequestBuilder T_Inv { get =>
            new T_InvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public T_Inv_2TRequestBuilder T_Inv_2T { get =>
            new T_Inv_2TRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TanRequestBuilder Tan { get =>
            new TanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TanhRequestBuilder Tanh { get =>
            new TanhRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TbillEqRequestBuilder TbillEq { get =>
            new TbillEqRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TbillPriceRequestBuilder TbillPrice { get =>
            new TbillPriceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TbillYieldRequestBuilder TbillYield { get =>
            new TbillYieldRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TextRequestBuilder Text { get =>
            new TextRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TimeRequestBuilder Time { get =>
            new TimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TimevalueRequestBuilder Timevalue { get =>
            new TimevalueRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TodayRequestBuilder Today { get =>
            new TodayRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TrimRequestBuilder Trim { get =>
            new TrimRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TrimMeanRequestBuilder TrimMean { get =>
            new TrimMeanRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TrueRequestBuilder True { get =>
            new TrueRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TruncRequestBuilder Trunc { get =>
            new TruncRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TypeRequestBuilder Type { get =>
            new TypeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UnicharRequestBuilder Unichar { get =>
            new UnicharRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UnicodeRequestBuilder Unicode { get =>
            new UnicodeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UpperRequestBuilder Upper { get =>
            new UpperRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UsdollarRequestBuilder Usdollar { get =>
            new UsdollarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ValueRequestBuilder Value { get =>
            new ValueRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Var_PRequestBuilder Var_P { get =>
            new Var_PRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Var_SRequestBuilder Var_S { get =>
            new Var_SRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VarARequestBuilder VarA { get =>
            new VarARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VarPARequestBuilder VarPA { get =>
            new VarPARequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VdbRequestBuilder Vdb { get =>
            new VdbRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VlookupRequestBuilder Vlookup { get =>
            new VlookupRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WeekdayRequestBuilder Weekday { get =>
            new WeekdayRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WeekNumRequestBuilder WeekNum { get =>
            new WeekNumRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Weibull_DistRequestBuilder Weibull_Dist { get =>
            new Weibull_DistRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkDayRequestBuilder WorkDay { get =>
            new WorkDayRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkDay_IntlRequestBuilder WorkDay_Intl { get =>
            new WorkDay_IntlRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public XirrRequestBuilder Xirr { get =>
            new XirrRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public XnpvRequestBuilder Xnpv { get =>
            new XnpvRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public XorRequestBuilder Xor { get =>
            new XorRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public YearRequestBuilder Year { get =>
            new YearRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public YearFracRequestBuilder YearFrac { get =>
            new YearFracRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public YieldRequestBuilder Yield { get =>
            new YieldRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public YieldDiscRequestBuilder YieldDisc { get =>
            new YieldDiscRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public YieldMatRequestBuilder YieldMat { get =>
            new YieldMatRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Z_TestRequestBuilder Z_Test { get =>
            new Z_TestRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new FunctionsRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public FunctionsRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/functions";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get functions from workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFunctions body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get functions from workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFunctions> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFunctions>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFunctions body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get functions from workbooks</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("CBT");

 public SelectOptionInfoResultT OptionVerification(QuizParamT reqQuizParam)
{
    SelectOptionInforesultT selOptResult = new SelectOptionInforesultT();
    selOptResult.Result = new CBTBaseResult();

    List<SelectOptionInfoT> lstSelOptInfo = new List<SelectOptionInfoT>();
    List<SelectOPtionParamT> lstSelOptParam = new List<SelectOPtionParamT>();

    stringstrMsg = String.Empty;
    int errorCnt = 0;

    if(reqQuizParam.OptSelYn == "Y" || reqQuizParam.OptAddYn == "Y")
    {
        string arrOptNo = reqQuizParam
    }
}

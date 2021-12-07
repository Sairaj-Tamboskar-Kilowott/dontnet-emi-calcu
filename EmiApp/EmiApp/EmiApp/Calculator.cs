namespace EmiApp
{
    public class Calculator: ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount; //* 12;
                var r = request.InterestRateInPercentage / 100;
                double e = 2.7183;
                var a = (double)p * Math.Pow(e, (r * t));
                
                // convert to response object
                response.EmiPayment = (decimal)a;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            //finally { }
            return response;
             
            throw new NotImplementedException();
        }

        public Response CalculateDailyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var t = request.LoanDurationInYearCount; // * 12;
                var r = request.InterestRateInPercentage / 100;
                double yd = 365;
                var d = (double)p *( Math.Pow((1 + (r / yd)), (yd * t))) - (double)p;
                // convert to response object
                response.EmiPayment = (decimal)d;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;

            throw new NotImplementedException();
        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 12, power);
                // convert to response object
                response.EmiPayment = (decimal) accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }
    }
}
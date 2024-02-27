update UsrRealtyFreedomUI 
set UsrCommission = 
  case
    when UsrOfferTypeId = 'CB83868D-3C1D-4C40-9A3A-E63B6B41B5B4' then UsrPriceUSD * 0.02  -- sale, 2%
    when UsrOfferTypeId = 'D9CDA457-FA45-4E08-B927-C0792F5DFA2C' then UsrPriceUSD * 0.50  -- rental, 50%
  end  
where UsrCommission = 0
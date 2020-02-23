using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CityCoordinate.Core;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;

namespace CityCoordinate.Api.Controllers
{
    [Route("api/coordinate")]
    public class СoordinateController : ControllerBase
    {
        private readonly ICityСoordinateSearcher _cityСoordinateSearcher;
        private readonly ICityСoordinateManager _cityСoordinateManager;
        //private readonly ICityСoordinateRepository _cityСoordinateRepository;
        

        public СoordinateController([NotNull]ICityСoordinateSearcher cityСoordinateSearcher,
                                    [NotNull] ICityСoordinateManager cityСoordinateManager)
        {
            _cityСoordinateSearcher = cityСoordinateSearcher ??
            throw new ArgumentNullException(nameof(cityСoordinateSearcher));
            _cityСoordinateManager = cityСoordinateManager ??
            throw new ArgumentNullException(nameof(cityСoordinateManager));
        }

        [HttpGet]
        [Route("save")]
        public async Task<IActionResult> Save()//string city)
        {
            //if (city == null)
            //    return BadRequest();
            string city = "Минесота";
            try
            {
                //var citys = await _cityСoordinateSearcher.GetСoordinate(city);

                var getList = 
                    _cityСoordinateManager.GetList();
                var checkList = 
                    _cityСoordinateManager.CheckList(city);

                //var coordinates = Map(citys);
                //_cityСoordinateManager.SaveList(citys);


                return Ok(checkList);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        private IList<CityСoordinate> Map(List<CityСoordinateInfo> info)
        {
            var cityСoordinates = new List<CityСoordinate>();


            foreach (var cityСoordinateInfo in info)
            {
                var cityСoordinate = new CityСoordinate
                {
                    Name = cityСoordinateInfo.DisplayName,
                    Latitude = cityСoordinateInfo.Lat,
                    Longitude = cityСoordinateInfo.Lon
                };
                cityСoordinates.Add(cityСoordinate);
            }
            return cityСoordinates;
        }

    }
}


var jobs = [];
var filteredObj = [];


function GetJobTitles(){

  fetch('https://localhost:44326/jobsearch')
  .then(function(res){
      return res.json();
  })
  .then(function(data){

     jobs = data;   
  });
}

function autocompleteMatch(input) {

    if (input == '' || input.length < 2) {
      return [];
    }    
    var reg = new RegExp(input,"gi")

    return jobs.filter(j => j.jobTitleName.match(reg));
}

function showResults(val) {
    res = document.getElementById("result");
    res.innerHTML = '';

    filteredObj  = autocompleteMatch(val);

    filteredObj.forEach(function(obj){

      res.innerHTML += '<ul>' + obj.jobTitleName + '</ul>';

    });

}

function getJobs()
{
  var titleId = filteredObj[0];
  res = document.getElementById("searches");
  res.innerHTML = '';


    fetch('https://localhost:44326/jobsearch/getjobs/' + titleId.jobTitleId)// + filteredObj[0].jobTitleId)
    .then(function(res){

       return res.json();
    })
    .then(
      function(data)
      {
        data.forEach((job, i) => res.innerHTML += '<ul>' + job.jobTitleName+ ' ' + job.state + ' ' + job.city + ' </ul>' );
        console.log(data);
      }       
      );
}






var slider = document.getElementById("myRange");
var output = document.getElementById("value");
output.innerHTML = slider.value; // Display the default slider value

// Update the current slider value (each time you drag the slider handle)
slider.oninput = function () {
    output.innerHTML = this.value;
    
    var element = document.getElementsByTagName("td");
    for (var j = 0; j < element.length; ++j) {
        element[j].style.color = 'black';
            element[j].style.fontWeight = 'normal';
    }
    for (var k = 0; k < element.length; ++k) {
        if (parseInt(element[k].id) > this.value) {
            element[k].style.color = 'green';
            element[k].style.fontWeight = 'bold';
        }
    }

    }



var home = (function () {
	'use scrict';

	var addFood = function (food) {
		var data = { "food": food };
		console.log(data);
		$.ajax({
			url: '/Home/AddFood/',
			data: data,
			type: 'POST',
			success: function (response) {
				console.log(response.message);
			}
		});
	};
	return {
		init: function () {
			$("[data-food-submit]").click(function () {
				event.preventDefault();
				var foodElement = $('input[type=text]');
				var food = foodElement.val();
				addFood(food);
			});
		}
	};
})();

$(function () {
	home.init();
});
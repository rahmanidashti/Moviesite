$('.owl-carousel').owlCarousel({
	loop: false,
	margin: 10,
	nav: false,
	dots: false,
	rtl: true,
	responsive: {
		0: {
			items: 4
		}
	}
});

$('#frm-search').submit(function (e) {
	e.preventDefault();

	var searchValue = $('#txt-search').val();
	search(searchValue);
});

$('#txt-search').keyup(function () {
	var searchValue = $(this).val();
	if (searchValue === '')
		$('.search-result').addClass('hide');
	else
		search(searchValue);
});

function search(searchValue) {
	$.ajax({
		url: '/home/search',
		type: 'get',
		data: {
			q: searchValue
		},
		success: function (data) {
			$('.search-result').removeClass('hide');
			var tmp = $('#scr-search').html();

			$('.search-result').html('');
			for (var i = 0; i < data.length; i++) {
				var tmp2 = tmp.replace('{{TITLE}}', data[i].title);
				$('.search-result').append($(tmp2));
			}
		}
	});
}


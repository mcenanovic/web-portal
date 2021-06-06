import { Component } from '@angular/core';
import SwiperCore, { Autoplay, Navigation, Pagination, SwiperOptions } from 'swiper/core';

SwiperCore.use([Navigation, Autoplay, Pagination]);

@Component({
  selector: 'wp-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent {
  config: SwiperOptions = {
    loop: true,
    slidesPerView: 1,
    centeredSlides: true,
    navigation: true,
    autoplay: {
      delay: 4000
    },
    pagination: {
        clickable: true
    },
    breakpoints: {
      599: {
        slidesPerView: 2
      }
    }
  };
}

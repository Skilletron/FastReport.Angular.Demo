import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
  title = 'app';
  show: boolean = false;
  url: string;
  report: string;

  Clicked() {
    if (this.report != null) {
      this.show = true;
      this.url = "api/SampleData/ShowReport?name=" + this.report;
    }
  }
}

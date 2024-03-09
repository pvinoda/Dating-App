import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClientModule } from '@angular/common/http'; // Import HttpClientModule

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    HttpClientModule // Add HttpClientModule to imports
  ],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'] // Note: It should be styleUrls (plural) not styleUrl
})
export class AppComponent implements OnInit {
  title = 'Dating Application';
  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: () => console.log('HTTP Request is now completed')
    });
  }
}

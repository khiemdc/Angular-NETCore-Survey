import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()

export class TeamService {
  myAppUrl: string = "";

  constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getTeams() {
    return this._http.get(this.myAppUrl + 'api/Team/GetTeamList')
  }

  getTotalVotes() {
    return this._http.get(this.myAppUrl + 'api/Team/TotalVotes');
  }

  saveVotes(team) {
    return this._http.put(this.myAppUrl + 'api/Team/UpdateVoteCount', team);
  }
}

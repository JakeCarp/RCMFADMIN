export class Team {
  constructor(data) {
    this.id = data.id;
    this.phone = data.phone;
    this.name = data.name;
    this.email = data.email;
    this.picture = data.picture;
    this.sponsorId = data.sponsorId;
    this.tournamentId = data.tournamentId;
  }
}

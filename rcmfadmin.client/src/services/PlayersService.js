import { AppState } from "../AppState.js"
import { Player } from "../models/Player.js"
import { mySQL } from "./AxiosService.js"

class PlayersService {
async getPlayers(){
  const res = await mySQL.get('players')
  AppState.players = res.data.map(p=> new Player(p))
}

async createPlayer(playerData){
  const res = await mySQL.post('players',playerData)
  let newPlayer = new Player(res.data)
  AppState.players.push(newPlayer)
}

async deletePlayer(playerId){
 await mySQL.delete(`players/${playerId}`)
AppState.players.filter(p=> p.id != playerId)
}
async editPlayer(playerData){
  const res = await mySQL.put('players',playerData)
  let updatedPlayer = new Player(res.data)
    let index = AppState.players.findIndex((p) => {
        p.id == playerData.id;
      });
  
      AppState.players.splice(index, 1);
      AppState.players.push(updatedPlayer)
}
}
export const playersService = new PlayersService()